from PyP100 import PyP100
p105 = PyP100.P100("192.168.X.X", "aaa@bbb.com", "password")
p105.handshake()
p105.login()
p105.turnOn()
p105.getDeviceInfo()