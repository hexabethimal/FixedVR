using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SimWinInput;
using System.Drawing;

namespace FixedVR
{    
    public partial class Main : Form
    {
        #region Variables        
        //Separate thread for receiving UDP
        private Thread ThreadingServer;
                
        //Initializes the UDP listener        
        private UdpClient listener;
        private IPEndPoint remoteEP;        
        private static int portNumber;
        private byte[] bytes;

        //Gamepad input
        private readonly SimGamePad simPad;
        private SimulatedGamePadState state;

        //Movement stopping
        private readonly int movementChunks;
        private List<int> xValues;        

        //Both Leg movement and stopping
        private string allMessages;
        private TimeSpan lastTime;
        private TimeSpan timeInterval = new TimeSpan(0, 0, 0, 0, 250);

        //UI variables
        private List<Control> userControls;
        private double stopSensitivity;
        private int walkSensitivity;
        private int stopDetection;
        private bool alwaysRun;
        private bool bothLegs;               
        private int changeMeasureWalk;        
        private int changeMeasureRun;        
        #endregion

        #region Form Start
        public Main()
        {            
            InitializeComponent();
            Size = new Size(464, 521);
            SimGamePad.Instance.Initialize();
            SimGamePad.Instance.PlugIn();
            simPad = SimGamePad.Instance;
            PopulateComboBoxes();
            InitiatePanelToolTips();
            GetAllUserControls();
            allMessages = "";
            movementChunks = 20;            

            //Suggested Initial Settings            
            Txt_walkmin.Text = "35";
            Combo_walksens.Text = " 3";
            Combo_detectrun.Text = "  20";            
            Txt_stopdetection.Text = "5";
            Combo_stopsensitivity.Text = " 2.0";            
            Radio_alwaysrunno.Checked = true;
            Radio_bothlegs.Checked = true;            
        }                
        
        private void StartUDPServer()
        {            
            try
            {
                while (true)
                {
                    bytes = listener.Receive(ref remoteEP);

                    if (bytes != null)
                    {
                        string dataFromClient = Encoding.UTF8.GetString(bytes);
                        ProcessReceived(dataFromClient);                        
                    }
                }
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                listener.Close();
            }
        }
        #endregion

        #region Message received and create inputs
        private void ProcessReceived(string message)
        {                                  
            int changeX = int.Parse(message.Split(',')[0]);
            xValues.Add(changeX);

            //Unused Accelerometer Readings
            //int changeY = int.Parse(message.Split(',')[1]);            
            //yValues.Add(changeY);
            //int changeZ = int.Parse(message.Split(',')[2]);            
            //zValues.Add(changeZ);                               

            //It takes at least 40 accelerometer readings for the processing code to run the calculations as written
            //This can be changed if the code in DelayedProcessing method is changed
            if (xValues.Count > 39)
            {
                //Only process controller input every 20 accelerometer readings.
                //While the frequency of readings is important to calculations, it isn't necessary to run calculations at speeds
                //that aren't meaningful to human movement speeds.
                if (xValues.Count % 20 == 0)
                {                                      
                    DelayedProcessing();
                }
            }
        }

        private void DelayedProcessing()
        {
            //Processes messages into 3 main types
            //"w" is walk
            //"r" is run
            //"+" is stop

            //Determine if movement or cancelled because side-to-side
            List<int> tempXList = new List<int>();
            List<int> tempStopList = new List<int>();           

            for (int i = xValues.Count - movementChunks; i < xValues.Count; i++)
            {
                tempXList.Add(xValues[i]);
            }            

            for (int i = xValues.Count - Convert.ToInt32(movementChunks * stopSensitivity); i < xValues.Count; i++)
            {
                tempStopList.Add(xValues[i]);
            }            

            //Determine if stopped                                
            bool existsStop = tempStopList.Exists(x => x > stopDetection);

            if (existsStop == false)
            {
                //stop
                ReceivedMessage("+");
            }
            else
            {
                //Determine if walk or run
                bool existsMove = tempXList.Exists(x => x > changeMeasureWalk);

                if (existsMove == true)
                {
                    bool isStillWalking = true;

                    if (allMessages.Length - changeMeasureRun >= 0)
                    {
                        List<string> recentMessages = new List<string>();

                        for (int i = 0; i < changeMeasureRun; i++)
                        {
                            recentMessages.Add(allMessages.Substring(allMessages.Length - changeMeasureRun + i, 1));
                        }
                        isStillWalking = recentMessages.Exists(x => x == "+");
                    }

                    if (isStillWalking == true)
                    {
                        ReceivedMessage("w");                        
                    }
                    else
                    {
                        //run     
                        ReceivedMessage("r");
                    }
                }
            }            
        }

        private void ReceivedMessage(string message)
        {
            //Limits walk/run movement input frequency to timeInterval Timespan, but stopping will occur regardless.
            //Important distinction to stop unintended movement while preserving responsive stopping
            if (DateTime.Now.TimeOfDay > lastTime + timeInterval)
            {
                //Process the client input
                bool acceptReceived = false;

                if (alwaysRun == true)
                {
                    if (message == "w")
                    {
                        message = "r";
                    }
                }

                if (allMessages.Length == 0)
                {
                    allMessages += message;
                    HandleThreadedAction(message);
                }
                else
                {
                    if (allMessages.Substring(allMessages.Length - 1, 1) == "+")
                    {
                        if (message != "+")
                        {
                            acceptReceived = true;
                        }
                    }
                    else
                    {
                        acceptReceived = true;
                    }

                    if (acceptReceived == true)
                    {
                        allMessages += message;

                        if (bothLegs == true)
                        {
                            string lastTwoLetters = allMessages.Substring(allMessages.Length - 2, 2);

                            if (lastTwoLetters == "ww" || lastTwoLetters == "wr" || lastTwoLetters == "rr" || lastTwoLetters == "rw" || lastTwoLetters == "+w" || lastTwoLetters == "+r")
                            {
                                HandleThreadedAction(message);
                            }
                            else
                            {
                                if (message == "+")
                                {
                                    HandleThreadedAction(message);
                                }
                            }                           
                        }
                        else
                        {
                            HandleThreadedAction(message);
                        }
                        lastTime = DateTime.Now.TimeOfDay;
                    }
                }
            }
            else
            {
                bool acceptReceived = false;
                if (allMessages.Length > 0)
                {
                    if (allMessages.Substring(allMessages.Length - 1, 1) != "+")
                    {
                        if (message == "+")
                        {
                            acceptReceived = true;
                        }
                    }

                    if (acceptReceived == true)
                    {
                        HandleThreadedAction(message);
                        lastTime = DateTime.Now.TimeOfDay;
                        allMessages += message;
                    }
                }
            }                        
        }

        private void HandleThreadedAction(string message)
        {
            Action doMessage = delegate { DoMessage(message); Application.OpenForms["Main"].Controls["Flowlayout_main"].Controls["Panel_debug"].Controls["Txt_debug"].Text += message; };
            Application.OpenForms["Main"].Invoke(doMessage);
        }

        private void DoMessage(string message)
        {            
            if (message == "w")
            {
                int wCount = 0;

                if (allMessages.Length > changeMeasureRun)
                {
                    for (int i = 0; i < changeMeasureRun - 1; i++)
                    {
                        if (allMessages.Substring(allMessages.Length - changeMeasureRun - 1, i) == "w")
                        {
                            wCount += 1;
                        }
                        else if (allMessages.Substring(allMessages.Length - changeMeasureRun - 1, i) == "+")
                        {
                            wCount = 0;
                        }
                    }
                }
                
                if (wCount < 10)
                {
                    state = simPad.State[0];
                    state.LeftStickY = WalkSpeed(walkSensitivity);                    
                    simPad.Update(0);
                }
                else if (wCount > 9 && wCount < 20)
                {
                    state = simPad.State[0];
                    state.LeftStickY = WalkSpeed(walkSensitivity + 1);                    
                    simPad.Update(0);
                }
                else if (wCount > 19 && wCount < 30)
                {
                    state = simPad.State[0];
                    state.LeftStickY = WalkSpeed(walkSensitivity + 2);                    
                    simPad.Update(0);
                }                
            }
            else if (message == "r")
            {
                state = simPad.State[0];
                state.LeftStickY = short.MaxValue;
                simPad.Update(0);
            }            
            else if (message == "+")
            {                
                if (state != null)
                {
                    state.Reset();
                    simPad.Update();
                }
            }            
        }  
        
        private short WalkSpeed(int walkSpeedNumerator)
        {
            if (walkSpeedNumerator > 7)
            {
                walkSpeedNumerator = 7;
            }
            return (short)(short.MaxValue * walkSpeedNumerator / 8);           
        }
        #endregion                     

        #region Form Settings and Controls
        private void GetAllUserControls()
        {
            userControls = new List<Control>();

            foreach (Control control in Controls)
            {
                if (control is FlowLayoutPanel && control.Name == "Flowlayout_main")
                {
                    foreach (Control mainPanel in control.Controls)
                    {
                        if (mainPanel is Panel && mainPanel.Name == "Panel_main")
                        {
                            foreach (Control subPanel in mainPanel.Controls)
                            {
                                if (subPanel is Panel)
                                {
                                    foreach (Control userControl in subPanel.Controls)
                                    {
                                        if (!(userControl is Label))
                                        {
                                            userControls.Add(userControl);                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ToggleUserControlEnabled(bool isEnabled)
        {
            foreach (Control control in userControls)
            {
                control.Enabled = isEnabled;
            }
        }

        private void PopulateComboBoxes()
        {
            List<string> detectRun = new List<string>
            {
                "  10",
                "  15",
                "  20",
                "  25",
                "  30"
            };

            for (int i = 0; i < detectRun.Count; i++)
            {
                Combo_detectrun.Items.Add(detectRun[i]);
            }

            List<string> detectStop = new List<string>
            {
                " 0.5",
                " 1.0",
                " 1.5",
                " 2.0",
                " 2.5"
            };

            for (int i = 0; i < detectStop.Count; i++)
            {
                Combo_stopsensitivity.Items.Add(detectStop[i]);
            }

            List<string> walkSens = new List<string>
            {
                " 2",
                " 3",
                " 4",
                " 5"
            };

            for (int i = 0; i < walkSens.Count; i++)
            {
                Combo_walksens.Items.Add(walkSens[i]);
            }            
        }

        private void InitiatePanelToolTips()
        {
            CreateToolTips(Panel_walkmin, "Minimum movement change to walk. Lower risks walking when not intending.");
            CreateToolTips(Panel_walksens, "Starting movement speed. Some games require stronger input to move.");
            CreateToolTips(Panel_runmin, "Required # of sequential walks to produce running speed.");            
            CreateToolTips(Panel_stopmax, "All movement changes below this number will be considered as stopped.");
            CreateToolTips(Panel_stopsense, "Lower is more sensitive, but may produce false stops.");
            CreateToolTips(Panel_alwaysrun, "If yes, applies run whenever walk is detected.");
            CreateToolTips(Panel_movement, "If each leg, each leg produces 1 movement forward. Both legs may seem more natural/intuitive.");            
            CreateToolTips(Panel_port, "Your specified port that must match the Arduino.");

            CreateToolTips(Lbl_walkmin, "Minimum movement change to walk. Lower risks walking when not intending.");
            CreateToolTips(Lbl_walksens, "Starting movement speed. Some games require stronger input to move.");
            CreateToolTips(Lbl_runmin, "Required # of sequential walks to produce running speed.");            
            CreateToolTips(Lbl_stopmax, "All movement changes below this number will be considered as stopped.");
            CreateToolTips(Lbl_stopsense, "Lower is more sensitive, but may produce false stops.");
            CreateToolTips(Lbl_alwaysrun, "If yes, applies run whenever walk is detected.");
            CreateToolTips(Lbl_movement, "If each leg, each leg produces 1 movement forward. Both legs may seem more natural/intuitive.");            
            CreateToolTips(Lbl_port, "Your specified port that must match the Arduino.");
        }

        private void CreateToolTips(Control controlName, string tooltipMessage)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(controlName, tooltipMessage);            
        }

        private void ComboBoxDesign_DrawItem(object sender, DrawItemEventArgs e)
        {            
            if (sender is ComboBox combobox)
            {               
                e.DrawBackground();
                
                if (e.Index > -1)
                {
                    StringFormat sf = new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    };
                    Brush brush = new SolidBrush(combobox.ForeColor);                                        
                    e.Graphics.DrawString(combobox.Items[e.Index].ToString(), combobox.Font, brush, e.Bounds, sf);
                }
            }
        }

        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex != -1)
            {
                label1.Focus();
            }
        }        
        #endregion

        #region Button Clicks
        private void Btn_connect_Click(object sender, EventArgs e)
        {
            if (Btn_connect.Text == "Start Receiving")
            {
                bool successful = true;

                try
                {
                    portNumber = int.Parse(Txt_serversocket.Text);
                }
                catch
                {
                    successful = false;
                    MessageBox.Show("Port is not valid.");
                }

                try
                {
                    changeMeasureWalk = int.Parse(Txt_walkmin.Text);                    
                    stopDetection = int.Parse(Txt_stopdetection.Text);
                }
                catch
                {
                    successful = false;
                    MessageBox.Show("Numbers must be integers.");
                }

                if (Radio_alwaysrunyes.Checked)
                {
                    alwaysRun = true;
                }
                else
                {
                    alwaysRun = false;
                }

                if (Radio_eachleg.Checked)
                {
                    bothLegs = false;
                }
                else
                {
                    bothLegs = true;
                }

                if (successful == true)
                {
                    walkSensitivity = int.Parse(Combo_walksens.Text.Trim());
                    changeMeasureRun = int.Parse(Combo_detectrun.Text.Trim());
                    stopSensitivity = double.Parse(Combo_stopsensitivity.Text.Trim());

                    try
                    {
                        listener = new UdpClient(portNumber);
                        remoteEP = new IPEndPoint(IPAddress.Any, portNumber);
                    }
                    catch
                    {
                        MessageBox.Show("Error initializing listener.");
                        Application.Exit();
                    }
                    ToggleUserControlEnabled(false);
                    xValues = new List<int>();
                    ThreadingServer = new Thread(StartUDPServer);
                    ThreadingServer.Start();
                    Btn_connect.Text = "Stop Receiving";
                }
            }
            else
            {
                ThreadingServer.Abort();
                Txt_debug.Text = "";
                Btn_connect.Text = "Start Receiving";
                ToggleUserControlEnabled(true);
            }
        }

        private void Btn_toggledebug_Click(object sender, EventArgs e)
        {
            if (Panel_debug.Visible == true)
            {
                Panel_debug.Visible = false;
                Panel_main.Visible = true;
            }
            else
            {
                Panel_main.Visible = false;
                Panel_debug.Visible = true;                
            }
        }

        private void Btn_stopdebug_Click(object sender, EventArgs e)
        {
            if (ThreadingServer != null)
            {
                ThreadingServer.Abort();
            }
            Btn_connect.Text = "Start Receiving";
            ToggleUserControlEnabled(true);
        }
        #endregion
    }
}
