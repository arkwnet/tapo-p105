from PyP100 import PyP100
p105 = PyP100.P100("192.168.X.X", "aaa@bbb.com", "password")
p105.handshake()
p105.login()
setup_args = p105.getDeviceInfo()
print(setup_args['result']['device_on'])
