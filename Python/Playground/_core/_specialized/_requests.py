import requests

response = requests.get("https://www.digitalocean.com/")
response = requests.get("https://translate.yandex.net/api/v1.5/tr.json/translate")
print(response)
print(response.json)
print(response.status_code)
print(response.headers)
print(response.text)
