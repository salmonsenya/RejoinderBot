��� ������� �����������-������� � ���� ��� ����� ����, ����� ����������������� ����������� ���������� �� �������� �������� Telegram ����, � �� ������� ����� �� ����� �������� ������, ����� � ������� � ����� � ��������� ���. ���� �������� ���������, ��-������, ����� ���������, ��-������, ����������������, ������� �� ������ ���������� ���������� ��� ������ � *Telegram Bot API*, � ���������� ������� �������. � �-�������, ��� ������ �������, ��� ��� � �� ���� ������ � ��������� ������������, �� ����������� � ������� ������.

����� ������ � ������� ������ � �������, ��� ��� �����������, ������ ����������� � ���������� DNS-�������� ����� ������ �����-�� �����.
# ������ Digital Ocean
��� ��� �������� �� �������� ��������� [Digital Ocean](https://www.digitalocean.com/). ����� ��� ���������� �������� �������� � ���, ��� � ��� ���� ���������, ������� ������� �� ������� ������� ����������� �������������. ������ �� $10-$100 ����� ��������, ��������, [�����](https://www.newcoupons.info/digitalocean-coupon-codes/).

## �������� ����� Droplet
* ������� (��������) � ���� ������� �� Digital Ocean
* ������� �� ������� *Billing -> Promo code* � �������� ���. (1 �������� �� 1 �������)
* �������� ����� *Droplet*: ��������� ���������� �� �������� *droplet*'� [Droplet Quickstart](https://www.digitalocean.com/docs/droplets/quickstart/).
    * �������� Ubuntu 20.04
    * ���� Basic ($5/�����)
    * Authentication == �������� *root* ������ (SSH ������� �����)
    * ��������� ��������� �� ���������
    
## ��������� ��������� ��������� �������
������� � *Droplet* ����� ������� (�� Windows ����� ������������ Windows PowerShell) ��� *root* �������������, �������� ������ ������������ � ������������ ��� ���������������� �����. [���� �� ��������� ��������� ������� Ubuntu 20.04](https://www.digitalocean.com/community/tutorials/initial-server-setup-with-ubuntu-20-04-ru).

## ��������� .NET Core SDK �� Ubuntu
#### ����������� ����� Microsoft
����� ���������� .NET ��� ���������� ���������������� ���� Microsoft, ���������������� ����������� Microsoft � ���������� ����������� �����������.
�������� ��������� ������ � ��������� ��������� �������:
```
wget -q https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
```

#### ��������� .NET Core SDK
���������� �������� ��������, ��������� ��� ���������, � ����� ���������� .NET SDK. � ��������� ������ ��������� ��������� �������:
```
sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install dotnet-sdk-3.1
```
��������� ������������ ���������:
```
dotnet --version
```

## ��������� Nginx �� Ubuntu
�� ����� ������������ ```apt-get``` ��� ��������� Nginx. ���������� ������� ������ ������������� *systemd*, ������� ����� ��������� Nginx ��� ����� ��� ������ ������� �������. �������� ��������� �������:
```
sudo -s
nginx=stable # use nginx=development for latest development version
add-apt-repository ppa:nginx/$nginx
apt-get update
apt-get install nginx
```
��������� Nginx ��� ���������� �������, �� ������ ���� ��������� ���, ��������:
```sudo service nginx start```
�� ����� ���������, ���������� �� ������� �������� �� ��������� ��� Nginx. ������� �������� �������� �� ������ ```http://<server_IP_address>```


# �������� ���
## ������� ������
����������� �������� ��� � ������ �� ����������������� �������������. ��������, � ������ ����� �� [REG.RU](https://www.reg.ru/), � ���������� ���� ����� � ��.

## ���������� ������ �� ������
������� � ������ ���������� Digital Ocean, �� ������� *Networking* [�������� �����](https://www.digitalocean.com/docs/networking/dns/how-to/add-domains/).
���������, ��� � ������ ���������� ��������� DNS-������ � ��� ������������� ��������:

| Type          | Hostname              | Value                       |
| ------------- | --------------------- | --------------------------- |
| A             | ```www.<domen_name>```| ```<server_IP_address>```   |
| A             | ```<domen_name>```    | ```<server_IP_address>```   |
| NS            | ```<domen_name>```    | ```ns1.digitalocean.com.``` |
| NS            | ```<domen_name>```    | ```ns2.digitalocean.com.``` |
| NS            | ```<domen_name>```    | ```ns3.digitalocean.com.``` |


������� � ������ ���������� ������������ ������ ������ � �������� ������������ �� ��������� DNS-������� �� ������� Digital Ocean. ����� ������ �������� ������ ���� ���������:  
```
ns1.digitalocean.com
ns2.digitalocean.com
ns3.digitalocean.com
```

## ������� SSL-�����������
� ���� �� ������������ ���������� SSL-���������� �� ���������� �������� ���. � ������ ������ SSL-���������� ������ DV �� 1 ��� ��� ����������� ������ �� REG.RU ����� �������� ���������.

## ��������� SSL-�����������
��������� ���� ����������� � ������������ ����� ������� - ��� ���������. �� ������� �� ���� �������:
1. ����������� TXT-������ �� ������, ������� ������ ������ ����� ������� �����������.
2. �������� TXT-������ �� ��� ������: ������� � ������ ���������� Digital Ocean, �������� �� ������� *Domains*, �������� ���� �����, � ��� ���� �������� ����� TXT-������.
3. ������. ����� ��������� SSL �� ���������� ����� ����� ������� ������ � ������� ��� ��������� SSL-�����������.
��������� ��� ��������� SSL-����������� �� REG.RU [���](https://www.reg.ru/support/ssl-sertifikaty/aktivatsiya-ssl-sertifikata/kak-dobavit-zapis-txt-dlya-besplatnogo-ssl-sertifikata).
4. ����� ��������� ����� ������� TXT-������ � �������.

# ��� �� ASP.NET Core
����� ���� ��� �������� ������������ ������� � ������ ���������, �������� � ������ ����.

## �������� ����
��������� ��������� ���� �� ����� *Telegram Bot Api* � �������� *token* ������ ���� � ������� BotFather. �������� �������� ���.

## �������� ASP.NET ����������
������� ��� � ����� MVC ����� �������, ���� ��������������� .NET �������� ��� ������ � *Telegram Bot API* [Telegram.Bot](https://github.com/TelegramBots/Telegram.Bot). � ���� ���� ������������, ���� � �������. �������� *token*, ���������� �� BotFather � �������, ��������, � *appsettings.json*.
���������, ��� ��� �������� �������� � �������� �� ```http://localhost:5000```, ```https://localhost:5001```.  ��������� ���� *update*'� (�������� ����� Postman). ������� *json*-�������� *update*'�� ����� ����� [�����](https://core.telegram.org/bots/webhooks#testing-your-bot-with-updates).

�������� *publish* ������� � ����� � ��������� �����. ������� � ��� ����� � ������� � ��������� ���������� ```dotnet <your_app_name>.dll```, ��������� ��� ��� ����� ��������.

## ���������� ���� �� ������� � ������� FileZilla
#### ��������� SSH
����� �������� ����� ������� �� ������ �� SFTP (SSH File Transfer Protocol), ������������� FileZilla - ���������� FTP-��������.
��� ����� ������� �������� SSH-�����, ������� �� � ������ *Droplet*'� � ��������� ������������ � ���������� ������� ����� SSH-����������. [���� ��� ��� �������](https://www.digitalocean.com/docs/droplets/how-to/add-ssh-keys/).

#### FileZilla
����� ����, ��� �� ��������� � ���, ��� SSH-���������� ��������, � ������� FileZilla ��������� ����� � *publish* ������� �� ��������� ������ [(��.����������)](https://www.digitalocean.com/docs/droplets/how-to/transfer-files/).

# ������ ���� �� �������
## ��������� SSL-����������� �� Nginx
� ���������� ���������� [����� �����������](https://www.reg.ru/support/ssl-sertifikaty/ustanovka-ssl-sertifikata/ustanovka-ssl-sertifikata-na-nginx) � ���������� ```/etc/ssl/``` ������� �������� ����� ����������� � ����� ```<ssl_certificate_name>.crt```, ```<ssl_key_name>.key```.

## ������������ Nginx
����� ��������� Nginx � �������� ��������� ������-������� ��� ��������� �������� � ���� ���������� ASP.NET Core, ��� ���������� �������� ���� ```/etc/nginx/sites-available/default```. �������������� ��� ���, ����� �� �������������� ����������� ���� ��������. �������� �������� �� ��, ��� ���������� � ����� ssl, ssl-����������� � �����, ������� �� �������� � ������������ Nginx � ���������� ������, �� ������ ����������.
```
server {
    listen 80;
    listen 443 ssl;
    ssl_certificate /etc/ssl/<ssl_certificate_name>.crt;
    ssl_certificate_key /etc/ssl/<ssl_key_name>.key;
    server_name <your_domen_name>;
    location / {
        proxy_pass https://localhost:5001;
        proxy_http_version 1.1;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection keep-alive;
        proxy_set_header Host $host;
        proxy_cache_bypass $http_upgrade;
    }
}
```

����� ����, ��� ������������ Nginx ��������, �� ������ ��������� ```sudo nginx -t```, ����� ��������� ��������� ������ ������������. ���� �������� ����� ������������ ������ �������, ����� ��������� Nginx ��������� ��������� � ������������, �������� ```sudo nginx -s reload```.

## ������ ���� ��� �������
�� ������ ������������ *systemd* ��� �������� ���������� ����� ��� ������� � ����������� �������� ���-����������. �������� ��������� ����:
```sudo nano /etc/systemd/system/<your_service_name>.service```
�����, ������ ����� ����� ��������� ��������� ��������� ������������:
```
[Unit]
Description=Pizdabot .NET Core Telegram Bot on Ubuntu

[Service]
WorkingDirectory=/root/discourteous
ExecStart=/usr/bin/dotnet /root/discourteous/DiscourteousBotWebhook.dll
Restart=always
RestartSec=10
SyslogIdentifier=offershare-web-app
Environment=ASPNETCORE_ENVIRONMENT=Production

[Install]
WantedBy=multi-user.target
```

������ ������� ������ ��������� � �������� ���:
```
 sudo systemctl enable <your_service_name>.service
 sudo systemctl start <your_service_name>.service
 sudo systemctl status <your_service_name>.service
```
������� *status* ������ ��������, ��� ������ �������� (���� ������������ ����������). ����, ���� ���-���������� ��������. �� ������� ���������� ��� ��� Linux � ������� Nginx.


# ��������� Webhook
��������� ���� �� ��������� *Webhook* ����� ��������� [�����](https://core.telegram.org/bots/webhooks#testing-your-bot-with-updates). �� ����, ��, ��� ���������� �������, - ��� �������� *Telegram*'� ����� ������ ����, ������� ��������� *update*'� � ������������ ��. ������� ��� ����� � ������� ������ *setWebHook*, ������ ������ (�������� ������ � ��������):
```https://api.telegram.org/bot{my_bot_token}/setWebhook?url={url_to_send_updates_to}```,  
���  
* ```my_bot_token``` - ��� �����, ������� �� �������� �� *BotFather*, ����� ��������� ���
* ```url_to_send_updates_to``` - *url* ������ ����, ��������������� ������� (����������� HTTPS)

# ������, �� �������������!
