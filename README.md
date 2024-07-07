# smtp-relay
* obj เพื่อใช้ mockup smtp (ทดสอบแบบ locally สำหรับทีม dev)
* ทีมต้องทราบว่า ปลายทางใช้ Internal SMTP Relay หรือ Hosted SMTP Relay
* ทีมต้องทราบว่า ปลายทางใช้ protocol แบบใด?  25, 465 หรือ 587

## condition ในการใช้งาน
* mailhog มี protocol port 25 ในการใช้งาน  
* ถ้าทีมต้องการทดสอบ protolcol port 587 STARTTLS แนะนำให้ไปใช้ Google App Password ในการส่งเมล์ ไม่แนะนำให้่ใช้ Less Secure Apps
