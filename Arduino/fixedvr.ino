#include <Arduino_LSM6DSOX.h>
#include <SPI.h>
#include <WiFiNINA.h>
#include <WiFiUdp.h>
#include <avr/dtostrf.h>

WiFiClient client;
WiFiUDP Udp;
char ssid[] = "your_wifi_network";
char pass[] = "your_wifi_password";
int status = WL_IDLE_STATUS;

IPAddress remoteHost(123,456,789,101);
uint16_t portNumber = 12345;  

float Ax, Ay, Az;
float lastX, lastY, lastZ;
float changeX, changeY, changeZ;

void setup() {   
  while (status != WL_CONNECTED) {    
    status = WiFi.begin(ssid, pass);
    delay(2000);
  }
  Udp.begin(portNumber); 
  if (!IMU.begin()) {                    
        while (1);
  }
  lastX = 0.000;            
  loop();
}

void loop() {     
  if (IMU.accelerationAvailable()) {
    IMU.readAcceleration(Ax, Ay, Az);
    
    if (lastX == 0.000) {
      lastX = Ax;
      lastY = Ay;
      lastZ = Az; 
    }
    else {    
      changeX = abs(Ax - lastX) * 100;
      char xVal[3];
      dtostrf(changeX, 3, 0, xVal);

      changeY = abs(Ay - lastY) * 100;
      char yVal[3];
      dtostrf(changeY, 3, 0, yVal);

      changeZ = abs(Az - lastZ) * 100;
      char zVal[3];
      dtostrf(changeZ, 3, 0, zVal);

      char str[12];      
      strcpy(str, xVal);
      strcat(str, ",");
      strcat(str, yVal);
      strcat(str, ",");
      strcat(str, zVal);            
            
      Udp.beginPacket(remoteHost, portNumber);      
      Udp.write(str);
      Udp.endPacket();      
      lastX = Ax;
      lastY = Ay;
      lastZ = Az; 
    } 
  }  
//Delay must be odd to prevent conflict with 104Hz IMU frequency  
delay(11);
}
