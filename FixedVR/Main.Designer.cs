
namespace FixedVR
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_debug = new System.Windows.Forms.TextBox();
            this.Btn_connect = new System.Windows.Forms.Button();
            this.Flowlayout_main = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_toggledebug = new System.Windows.Forms.Button();
            this.Panel_debug = new System.Windows.Forms.Panel();
            this.Btn_stopdebug = new System.Windows.Forms.Button();
            this.Panel_main = new System.Windows.Forms.Panel();
            this.Panel_walkmin = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_walkmin = new System.Windows.Forms.TextBox();
            this.Lbl_walkmin = new System.Windows.Forms.Label();
            this.Panel_stopmax = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_stopdetection = new System.Windows.Forms.TextBox();
            this.Lbl_stopmax = new System.Windows.Forms.Label();
            this.Panel_runmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Combo_detectrun = new System.Windows.Forms.ComboBox();
            this.Lbl_runmin = new System.Windows.Forms.Label();
            this.Panel_stopsense = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Combo_stopsensitivity = new System.Windows.Forms.ComboBox();
            this.Lbl_stopsense = new System.Windows.Forms.Label();
            this.Panel_port = new System.Windows.Forms.Panel();
            this.Txt_serversocket = new System.Windows.Forms.TextBox();
            this.Lbl_port = new System.Windows.Forms.Label();
            this.Panel_alwaysrun = new System.Windows.Forms.Panel();
            this.Radio_alwaysrunno = new System.Windows.Forms.RadioButton();
            this.Lbl_alwaysrun = new System.Windows.Forms.Label();
            this.Radio_alwaysrunyes = new System.Windows.Forms.RadioButton();
            this.Panel_movement = new System.Windows.Forms.Panel();
            this.Radio_bothlegs = new System.Windows.Forms.RadioButton();
            this.Lbl_movement = new System.Windows.Forms.Label();
            this.Radio_eachleg = new System.Windows.Forms.RadioButton();
            this.Panel_sidewaysense = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.Txt_sidesensitivity = new System.Windows.Forms.TextBox();
            this.Lbl_sidewaysense = new System.Windows.Forms.Label();
            this.Panel_walkmax = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_walkmax = new System.Windows.Forms.TextBox();
            this.Lbl_walkmax = new System.Windows.Forms.Label();
            this.Flowlayout_main.SuspendLayout();
            this.Panel_debug.SuspendLayout();
            this.Panel_main.SuspendLayout();
            this.Panel_walkmin.SuspendLayout();
            this.Panel_stopmax.SuspendLayout();
            this.Panel_runmin.SuspendLayout();
            this.Panel_stopsense.SuspendLayout();
            this.Panel_port.SuspendLayout();
            this.Panel_alwaysrun.SuspendLayout();
            this.Panel_movement.SuspendLayout();
            this.Panel_sidewaysense.SuspendLayout();
            this.Panel_walkmax.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_debug
            // 
            this.Txt_debug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_debug.Location = new System.Drawing.Point(3, 3);
            this.Txt_debug.Multiline = true;
            this.Txt_debug.Name = "Txt_debug";
            this.Txt_debug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_debug.Size = new System.Drawing.Size(421, 324);
            this.Txt_debug.TabIndex = 0;
            this.Txt_debug.TabStop = false;
            // 
            // Btn_connect
            // 
            this.Btn_connect.BackColor = System.Drawing.Color.SpringGreen;
            this.Btn_connect.FlatAppearance.BorderSize = 2;
            this.Btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_connect.Location = new System.Drawing.Point(3, 319);
            this.Btn_connect.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_connect.Name = "Btn_connect";
            this.Btn_connect.Size = new System.Drawing.Size(421, 42);
            this.Btn_connect.TabIndex = 6;
            this.Btn_connect.TabStop = false;
            this.Btn_connect.Text = "Start Receiving";
            this.Btn_connect.UseVisualStyleBackColor = false;
            this.Btn_connect.Click += new System.EventHandler(this.Btn_connect_Click);
            // 
            // Flowlayout_main
            // 
            this.Flowlayout_main.Controls.Add(this.Btn_toggledebug);
            this.Flowlayout_main.Controls.Add(this.Panel_debug);
            this.Flowlayout_main.Controls.Add(this.Panel_main);
            this.Flowlayout_main.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flowlayout_main.Location = new System.Drawing.Point(7, 8);
            this.Flowlayout_main.Name = "Flowlayout_main";
            this.Flowlayout_main.Size = new System.Drawing.Size(436, 794);
            this.Flowlayout_main.TabIndex = 7;
            // 
            // Btn_toggledebug
            // 
            this.Btn_toggledebug.BackColor = System.Drawing.Color.LightSlateGray;
            this.Btn_toggledebug.FlatAppearance.BorderSize = 2;
            this.Btn_toggledebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_toggledebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_toggledebug.ForeColor = System.Drawing.Color.White;
            this.Btn_toggledebug.Location = new System.Drawing.Point(3, 3);
            this.Btn_toggledebug.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.Btn_toggledebug.Name = "Btn_toggledebug";
            this.Btn_toggledebug.Size = new System.Drawing.Size(428, 42);
            this.Btn_toggledebug.TabIndex = 8;
            this.Btn_toggledebug.TabStop = false;
            this.Btn_toggledebug.Text = "Toggle Debug Panel";
            this.Btn_toggledebug.UseVisualStyleBackColor = false;
            this.Btn_toggledebug.Click += new System.EventHandler(this.Btn_toggledebug_Click);
            // 
            // Panel_debug
            // 
            this.Panel_debug.Controls.Add(this.Btn_stopdebug);
            this.Panel_debug.Controls.Add(this.Txt_debug);
            this.Panel_debug.Location = new System.Drawing.Point(3, 49);
            this.Panel_debug.Name = "Panel_debug";
            this.Panel_debug.Size = new System.Drawing.Size(428, 367);
            this.Panel_debug.TabIndex = 8;
            this.Panel_debug.Visible = false;
            // 
            // Btn_stopdebug
            // 
            this.Btn_stopdebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_stopdebug.Location = new System.Drawing.Point(3, 333);
            this.Btn_stopdebug.Name = "Btn_stopdebug";
            this.Btn_stopdebug.Size = new System.Drawing.Size(421, 31);
            this.Btn_stopdebug.TabIndex = 5;
            this.Btn_stopdebug.TabStop = false;
            this.Btn_stopdebug.Text = "Stop Debug";
            this.Btn_stopdebug.UseVisualStyleBackColor = true;
            this.Btn_stopdebug.Click += new System.EventHandler(this.Btn_stopdebug_Click);
            // 
            // Panel_main
            // 
            this.Panel_main.Controls.Add(this.Panel_walkmin);
            this.Panel_main.Controls.Add(this.Panel_stopmax);
            this.Panel_main.Controls.Add(this.Panel_runmin);
            this.Panel_main.Controls.Add(this.Panel_stopsense);
            this.Panel_main.Controls.Add(this.Panel_port);
            this.Panel_main.Controls.Add(this.Panel_alwaysrun);
            this.Panel_main.Controls.Add(this.Panel_movement);
            this.Panel_main.Controls.Add(this.Btn_connect);
            this.Panel_main.Location = new System.Drawing.Point(3, 422);
            this.Panel_main.Name = "Panel_main";
            this.Panel_main.Size = new System.Drawing.Size(428, 367);
            this.Panel_main.TabIndex = 9;
            // 
            // Panel_walkmin
            // 
            this.Panel_walkmin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_walkmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_walkmin.Controls.Add(this.label12);
            this.Panel_walkmin.Controls.Add(this.Txt_walkmin);
            this.Panel_walkmin.Controls.Add(this.Lbl_walkmin);
            this.Panel_walkmin.Location = new System.Drawing.Point(3, 5);
            this.Panel_walkmin.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_walkmin.Name = "Panel_walkmin";
            this.Panel_walkmin.Size = new System.Drawing.Size(421, 35);
            this.Panel_walkmin.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(323, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "(1-2 digits)";
            // 
            // Txt_walkmin
            // 
            this.Txt_walkmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_walkmin.Location = new System.Drawing.Point(217, 3);
            this.Txt_walkmin.MaxLength = 2;
            this.Txt_walkmin.Name = "Txt_walkmin";
            this.Txt_walkmin.Size = new System.Drawing.Size(81, 26);
            this.Txt_walkmin.TabIndex = 10;
            this.Txt_walkmin.TabStop = false;
            this.Txt_walkmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_walkmin
            // 
            this.Lbl_walkmin.AutoSize = true;
            this.Lbl_walkmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_walkmin.Location = new System.Drawing.Point(3, 6);
            this.Lbl_walkmin.Name = "Lbl_walkmin";
            this.Lbl_walkmin.Size = new System.Drawing.Size(182, 20);
            this.Lbl_walkmin.TabIndex = 9;
            this.Lbl_walkmin.Text = "Minimum Detect Walk";
            // 
            // Panel_stopmax
            // 
            this.Panel_stopmax.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_stopmax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_stopmax.Controls.Add(this.label2);
            this.Panel_stopmax.Controls.Add(this.Txt_stopdetection);
            this.Panel_stopmax.Controls.Add(this.Lbl_stopmax);
            this.Panel_stopmax.Location = new System.Drawing.Point(3, 95);
            this.Panel_stopmax.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_stopmax.Name = "Panel_stopmax";
            this.Panel_stopmax.Size = new System.Drawing.Size(421, 35);
            this.Panel_stopmax.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "(1-2 digits)";
            // 
            // Txt_stopdetection
            // 
            this.Txt_stopdetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_stopdetection.Location = new System.Drawing.Point(217, 3);
            this.Txt_stopdetection.MaxLength = 2;
            this.Txt_stopdetection.Name = "Txt_stopdetection";
            this.Txt_stopdetection.Size = new System.Drawing.Size(81, 26);
            this.Txt_stopdetection.TabIndex = 10;
            this.Txt_stopdetection.TabStop = false;
            this.Txt_stopdetection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_stopmax
            // 
            this.Lbl_stopmax.AutoSize = true;
            this.Lbl_stopmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_stopmax.Location = new System.Drawing.Point(3, 6);
            this.Lbl_stopmax.Name = "Lbl_stopmax";
            this.Lbl_stopmax.Size = new System.Drawing.Size(185, 20);
            this.Lbl_stopmax.TabIndex = 9;
            this.Lbl_stopmax.Text = "Maximum Detect Stop";
            // 
            // Panel_runmin
            // 
            this.Panel_runmin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_runmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_runmin.Controls.Add(this.label1);
            this.Panel_runmin.Controls.Add(this.Combo_detectrun);
            this.Panel_runmin.Controls.Add(this.Lbl_runmin);
            this.Panel_runmin.Location = new System.Drawing.Point(3, 50);
            this.Panel_runmin.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_runmin.Name = "Panel_runmin";
            this.Panel_runmin.Size = new System.Drawing.Size(421, 35);
            this.Panel_runmin.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "(# of walks)";
            // 
            // Combo_detectrun
            // 
            this.Combo_detectrun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combo_detectrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_detectrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_detectrun.FormattingEnabled = true;
            this.Combo_detectrun.Location = new System.Drawing.Point(217, 3);
            this.Combo_detectrun.Name = "Combo_detectrun";
            this.Combo_detectrun.Size = new System.Drawing.Size(81, 27);
            this.Combo_detectrun.TabIndex = 10;
            this.Combo_detectrun.TabStop = false;
            this.Combo_detectrun.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxDesign_DrawItem);
            this.Combo_detectrun.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // Lbl_runmin
            // 
            this.Lbl_runmin.AutoSize = true;
            this.Lbl_runmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_runmin.Location = new System.Drawing.Point(3, 6);
            this.Lbl_runmin.Name = "Lbl_runmin";
            this.Lbl_runmin.Size = new System.Drawing.Size(176, 20);
            this.Lbl_runmin.TabIndex = 9;
            this.Lbl_runmin.Text = "Minimum Detect Run";
            // 
            // Panel_stopsense
            // 
            this.Panel_stopsense.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_stopsense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_stopsense.Controls.Add(this.label3);
            this.Panel_stopsense.Controls.Add(this.Combo_stopsensitivity);
            this.Panel_stopsense.Controls.Add(this.Lbl_stopsense);
            this.Panel_stopsense.Location = new System.Drawing.Point(3, 140);
            this.Panel_stopsense.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_stopsense.Name = "Panel_stopsense";
            this.Panel_stopsense.Size = new System.Drawing.Size(421, 35);
            this.Panel_stopsense.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "(multiplier)";
            // 
            // Combo_stopsensitivity
            // 
            this.Combo_stopsensitivity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combo_stopsensitivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_stopsensitivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_stopsensitivity.FormattingEnabled = true;
            this.Combo_stopsensitivity.Location = new System.Drawing.Point(217, 3);
            this.Combo_stopsensitivity.Name = "Combo_stopsensitivity";
            this.Combo_stopsensitivity.Size = new System.Drawing.Size(81, 27);
            this.Combo_stopsensitivity.TabIndex = 8;
            this.Combo_stopsensitivity.TabStop = false;
            this.Combo_stopsensitivity.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxDesign_DrawItem);
            this.Combo_stopsensitivity.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // Lbl_stopsense
            // 
            this.Lbl_stopsense.AutoSize = true;
            this.Lbl_stopsense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_stopsense.Location = new System.Drawing.Point(3, 6);
            this.Lbl_stopsense.Name = "Lbl_stopsense";
            this.Lbl_stopsense.Size = new System.Drawing.Size(133, 20);
            this.Lbl_stopsense.TabIndex = 7;
            this.Lbl_stopsense.Text = "Stop Sensitivity";
            // 
            // Panel_port
            // 
            this.Panel_port.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_port.Controls.Add(this.Txt_serversocket);
            this.Panel_port.Controls.Add(this.Lbl_port);
            this.Panel_port.Location = new System.Drawing.Point(3, 275);
            this.Panel_port.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_port.Name = "Panel_port";
            this.Panel_port.Size = new System.Drawing.Size(421, 34);
            this.Panel_port.TabIndex = 19;
            // 
            // Txt_serversocket
            // 
            this.Txt_serversocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_serversocket.Location = new System.Drawing.Point(166, 3);
            this.Txt_serversocket.MaxLength = 5;
            this.Txt_serversocket.Name = "Txt_serversocket";
            this.Txt_serversocket.Size = new System.Drawing.Size(250, 26);
            this.Txt_serversocket.TabIndex = 21;
            this.Txt_serversocket.TabStop = false;
            this.Txt_serversocket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_port
            // 
            this.Lbl_port.AutoSize = true;
            this.Lbl_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_port.ForeColor = System.Drawing.Color.White;
            this.Lbl_port.Location = new System.Drawing.Point(3, 6);
            this.Lbl_port.Name = "Lbl_port";
            this.Lbl_port.Size = new System.Drawing.Size(115, 20);
            this.Lbl_port.TabIndex = 11;
            this.Lbl_port.Text = "Wireless Port";
            // 
            // Panel_alwaysrun
            // 
            this.Panel_alwaysrun.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_alwaysrun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_alwaysrun.Controls.Add(this.Radio_alwaysrunno);
            this.Panel_alwaysrun.Controls.Add(this.Lbl_alwaysrun);
            this.Panel_alwaysrun.Controls.Add(this.Radio_alwaysrunyes);
            this.Panel_alwaysrun.Location = new System.Drawing.Point(3, 185);
            this.Panel_alwaysrun.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_alwaysrun.Name = "Panel_alwaysrun";
            this.Panel_alwaysrun.Size = new System.Drawing.Size(421, 35);
            this.Panel_alwaysrun.TabIndex = 15;
            // 
            // Radio_alwaysrunno
            // 
            this.Radio_alwaysrunno.AutoSize = true;
            this.Radio_alwaysrunno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_alwaysrunno.Location = new System.Drawing.Point(318, 4);
            this.Radio_alwaysrunno.Name = "Radio_alwaysrunno";
            this.Radio_alwaysrunno.Size = new System.Drawing.Size(47, 24);
            this.Radio_alwaysrunno.TabIndex = 18;
            this.Radio_alwaysrunno.Text = "No";
            this.Radio_alwaysrunno.UseVisualStyleBackColor = true;
            // 
            // Lbl_alwaysrun
            // 
            this.Lbl_alwaysrun.AutoSize = true;
            this.Lbl_alwaysrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_alwaysrun.Location = new System.Drawing.Point(3, 7);
            this.Lbl_alwaysrun.Name = "Lbl_alwaysrun";
            this.Lbl_alwaysrun.Size = new System.Drawing.Size(112, 20);
            this.Lbl_alwaysrun.TabIndex = 12;
            this.Lbl_alwaysrun.Text = "Always Run?";
            // 
            // Radio_alwaysrunyes
            // 
            this.Radio_alwaysrunyes.AutoSize = true;
            this.Radio_alwaysrunyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_alwaysrunyes.Location = new System.Drawing.Point(217, 4);
            this.Radio_alwaysrunyes.Name = "Radio_alwaysrunyes";
            this.Radio_alwaysrunyes.Size = new System.Drawing.Size(55, 24);
            this.Radio_alwaysrunyes.TabIndex = 17;
            this.Radio_alwaysrunyes.Text = "Yes";
            this.Radio_alwaysrunyes.UseVisualStyleBackColor = true;
            // 
            // Panel_movement
            // 
            this.Panel_movement.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_movement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_movement.Controls.Add(this.Radio_bothlegs);
            this.Panel_movement.Controls.Add(this.Lbl_movement);
            this.Panel_movement.Controls.Add(this.Radio_eachleg);
            this.Panel_movement.Location = new System.Drawing.Point(3, 230);
            this.Panel_movement.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_movement.Name = "Panel_movement";
            this.Panel_movement.Size = new System.Drawing.Size(421, 35);
            this.Panel_movement.TabIndex = 14;
            // 
            // Radio_bothlegs
            // 
            this.Radio_bothlegs.AutoSize = true;
            this.Radio_bothlegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_bothlegs.Location = new System.Drawing.Point(318, 4);
            this.Radio_bothlegs.Name = "Radio_bothlegs";
            this.Radio_bothlegs.Size = new System.Drawing.Size(100, 24);
            this.Radio_bothlegs.TabIndex = 16;
            this.Radio_bothlegs.Text = "Both Legs";
            this.Radio_bothlegs.UseVisualStyleBackColor = true;
            // 
            // Lbl_movement
            // 
            this.Lbl_movement.AutoSize = true;
            this.Lbl_movement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_movement.Location = new System.Drawing.Point(3, 6);
            this.Lbl_movement.Name = "Lbl_movement";
            this.Lbl_movement.Size = new System.Drawing.Size(175, 20);
            this.Lbl_movement.TabIndex = 13;
            this.Lbl_movement.Text = "Movement Activation";
            // 
            // Radio_eachleg
            // 
            this.Radio_eachleg.AutoSize = true;
            this.Radio_eachleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_eachleg.Location = new System.Drawing.Point(217, 4);
            this.Radio_eachleg.Name = "Radio_eachleg";
            this.Radio_eachleg.Size = new System.Drawing.Size(95, 24);
            this.Radio_eachleg.TabIndex = 15;
            this.Radio_eachleg.Text = "Each Leg";
            this.Radio_eachleg.UseVisualStyleBackColor = true;
            // 
            // Panel_sidewaysense
            // 
            this.Panel_sidewaysense.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_sidewaysense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_sidewaysense.Controls.Add(this.label14);
            this.Panel_sidewaysense.Controls.Add(this.Txt_sidesensitivity);
            this.Panel_sidewaysense.Controls.Add(this.Lbl_sidewaysense);
            this.Panel_sidewaysense.Location = new System.Drawing.Point(528, 605);
            this.Panel_sidewaysense.Name = "Panel_sidewaysense";
            this.Panel_sidewaysense.Size = new System.Drawing.Size(421, 33);
            this.Panel_sidewaysense.TabIndex = 24;
            this.Panel_sidewaysense.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(323, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "(1-2 digits)";
            // 
            // Txt_sidesensitivity
            // 
            this.Txt_sidesensitivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sidesensitivity.Location = new System.Drawing.Point(236, 3);
            this.Txt_sidesensitivity.MaxLength = 2;
            this.Txt_sidesensitivity.Name = "Txt_sidesensitivity";
            this.Txt_sidesensitivity.Size = new System.Drawing.Size(81, 26);
            this.Txt_sidesensitivity.TabIndex = 10;
            this.Txt_sidesensitivity.TabStop = false;
            this.Txt_sidesensitivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_sidewaysense
            // 
            this.Lbl_sidewaysense.AutoSize = true;
            this.Lbl_sidewaysense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sidewaysense.Location = new System.Drawing.Point(3, 6);
            this.Lbl_sidewaysense.Name = "Lbl_sidewaysense";
            this.Lbl_sidewaysense.Size = new System.Drawing.Size(218, 20);
            this.Lbl_sidewaysense.TabIndex = 9;
            this.Lbl_sidewaysense.Text = "Minimum Detect Sideways";
            // 
            // Panel_walkmax
            // 
            this.Panel_walkmax.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_walkmax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_walkmax.Controls.Add(this.label10);
            this.Panel_walkmax.Controls.Add(this.Txt_walkmax);
            this.Panel_walkmax.Controls.Add(this.Lbl_walkmax);
            this.Panel_walkmax.Location = new System.Drawing.Point(528, 680);
            this.Panel_walkmax.Name = "Panel_walkmax";
            this.Panel_walkmax.Size = new System.Drawing.Size(421, 33);
            this.Panel_walkmax.TabIndex = 22;
            this.Panel_walkmax.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "(1-2 digits)";
            // 
            // Txt_walkmax
            // 
            this.Txt_walkmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_walkmax.Location = new System.Drawing.Point(236, 3);
            this.Txt_walkmax.MaxLength = 2;
            this.Txt_walkmax.Name = "Txt_walkmax";
            this.Txt_walkmax.Size = new System.Drawing.Size(81, 26);
            this.Txt_walkmax.TabIndex = 10;
            this.Txt_walkmax.TabStop = false;
            this.Txt_walkmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_walkmax
            // 
            this.Lbl_walkmax.AutoSize = true;
            this.Lbl_walkmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_walkmax.Location = new System.Drawing.Point(3, 6);
            this.Lbl_walkmax.Name = "Lbl_walkmax";
            this.Lbl_walkmax.Size = new System.Drawing.Size(186, 20);
            this.Lbl_walkmax.TabIndex = 9;
            this.Lbl_walkmax.Text = "Maximum Detect Walk";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(450, 431);
            this.Controls.Add(this.Panel_sidewaysense);
            this.Controls.Add(this.Flowlayout_main);
            this.Controls.Add(this.Panel_walkmax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FixedVR";
            this.TopMost = true;
            this.Flowlayout_main.ResumeLayout(false);
            this.Panel_debug.ResumeLayout(false);
            this.Panel_debug.PerformLayout();
            this.Panel_main.ResumeLayout(false);
            this.Panel_walkmin.ResumeLayout(false);
            this.Panel_walkmin.PerformLayout();
            this.Panel_stopmax.ResumeLayout(false);
            this.Panel_stopmax.PerformLayout();
            this.Panel_runmin.ResumeLayout(false);
            this.Panel_runmin.PerformLayout();
            this.Panel_stopsense.ResumeLayout(false);
            this.Panel_stopsense.PerformLayout();
            this.Panel_port.ResumeLayout(false);
            this.Panel_port.PerformLayout();
            this.Panel_alwaysrun.ResumeLayout(false);
            this.Panel_alwaysrun.PerformLayout();
            this.Panel_movement.ResumeLayout(false);
            this.Panel_movement.PerformLayout();
            this.Panel_sidewaysense.ResumeLayout(false);
            this.Panel_sidewaysense.PerformLayout();
            this.Panel_walkmax.ResumeLayout(false);
            this.Panel_walkmax.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_debug;
        private System.Windows.Forms.Button Btn_connect;
        private System.Windows.Forms.FlowLayoutPanel Flowlayout_main;
        private System.Windows.Forms.Panel Panel_debug;
        private System.Windows.Forms.Panel Panel_main;
        private System.Windows.Forms.Button Btn_toggledebug;
        private System.Windows.Forms.Label Lbl_stopsense;
        private System.Windows.Forms.Label Lbl_stopmax;
        private System.Windows.Forms.Label Lbl_port;
        private System.Windows.Forms.Panel Panel_port;
        private System.Windows.Forms.Panel Panel_stopsense;
        private System.Windows.Forms.Panel Panel_stopmax;
        private System.Windows.Forms.Panel Panel_alwaysrun;
        private System.Windows.Forms.RadioButton Radio_alwaysrunno;
        private System.Windows.Forms.Label Lbl_alwaysrun;
        private System.Windows.Forms.RadioButton Radio_alwaysrunyes;
        private System.Windows.Forms.Panel Panel_movement;
        private System.Windows.Forms.RadioButton Radio_bothlegs;
        private System.Windows.Forms.Label Lbl_movement;
        private System.Windows.Forms.RadioButton Radio_eachleg;
        private System.Windows.Forms.TextBox Txt_serversocket;
        private System.Windows.Forms.ComboBox Combo_stopsensitivity;
        private System.Windows.Forms.TextBox Txt_stopdetection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_walkmin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_walkmin;
        private System.Windows.Forms.Label Lbl_walkmin;
        private System.Windows.Forms.Panel Panel_walkmax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_walkmax;
        private System.Windows.Forms.Label Lbl_walkmax;
        private System.Windows.Forms.Panel Panel_runmin;
        private System.Windows.Forms.Label Lbl_runmin;
        private System.Windows.Forms.Panel Panel_sidewaysense;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Txt_sidesensitivity;
        private System.Windows.Forms.Label Lbl_sidewaysense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Combo_detectrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_stopdebug;
    }
}

