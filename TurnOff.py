from PyP100 import PyP100
# Please insert IP address of smart plug, TP-Link user ID and password
p105 = PyP100.P100("192.168.X.X", "aaa@bbb.com", "password")
p105.handshake()
p105.login()
p105.turnOff()
p105.getDeviceInfo()