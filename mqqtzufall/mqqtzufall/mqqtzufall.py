
import time
import paho.mqtt.subscribe as subscribe
from random import *
from turtle import delay

import paho.mqtt.client as mqtt

def on_connect(client, userdata, flags, rc):
    print("Connected with result code " + str(rc))
    client.subscribe("temp", 0)
    client.subscribe("light", 0)

def on_message(client, userdata, message):
    msg = str(message.payload.decode("utf-8"))
    print( message.topic,": ",  msg)



client = mqtt.Client()
client.on_connect = on_connect
client.on_message = on_message

client.connect("10.0.0.70", 1883, 60)

client.loop_start()



while True:
    time.sleep(3)
    client.publish("temp", randint(0, 60))