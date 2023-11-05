import webbrowser

webbrowser.open("http://www.google.com")

from email.mime.multipart import MIMEMultipart
from email.mime.text import MIMEText
from email.mime.image import MIMEImage
import smtplib


message = MIMEMultipart()
message["form"] = "Ronnie"
message["to"] = "rk612345@gmail.com"
message["subject"] = "test"
message.attach(MIMEText("the body"))
message.attach(MIMEImage("image.png"))

with smtplib.SMTP(host="smtp.gmail.com", port=587) as smtp:
    smtp.ehlo()
    smtp.starttls()
    smtp.login("rk612345@gmail.com", "RIsryi633")
    smtp.send_message(message)
    print("sent")
