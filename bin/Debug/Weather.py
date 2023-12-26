import time
from selenium import webdriver
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.common.by import By
from datetime import datetime, date

import matplotlib.pyplot as plt

chrome_options = Options()

chrome_options.add_argument("--headless")

# Открываем веб-драйвер Chrome
driver = webdriver.Chrome(chrome_options)

# Загружаем веб-страницу
driver.get('https://www.hmn.ru/index.php?index=8&value=29570')

#capture_path = 'C:/capture/your_desired_filename.png'
#driver.save_screenshot(capture_path)

# Можно добавить задержку, чтобы страница полностью прогрузилась
time.sleep(5)

elements = driver.find_elements(By.CLASS_NAME, "fon_gray_light")

time.sleep(5)



text_parse = []
for e in elements:
    t = e.text.split("\n")
    text_parse.append(t)

time.sleep(5)
# Закрываем веб-драйвер и выходим
driver.quit()

head = [""]

time_hour = text_parse[1][0].split(':')[0]

dataDays = text_parse[1][1].replace("г", "").split('.')
day = dataDays[0]
mouth = dataDays[1]
year = dataDays[2]

s = ""
for c in text_parse[1][2]:
    if(c in ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', "-", "+", " "]):
        s+=c
s = s.lstrip()
s = s.split(' ')



# град град   %     мм рт ст
Temp, dTemp, Water, Pressure = s[0], s[1], s[2], s[3]

data = datetime(int(year), int(mouth), int(day), int(time_hour),  0, 0)
data_text = data.strftime("%Y-%m-%d-%H-%M")

# Проверяю есть ли у меня уже такая дата в файле'''
read = ""
with open("Weather.txt", "r") as file:
    read = file.readlines()

dataBuf = []
dataTemp, datadTemp, dataWater, dataPressure = [], [], [], []
for row in read:
    arr = row.split(';')
    d = arr[0].split('-')
    dbuf = datetime(int(d[0]), int(d[1]), int(d[2]), int(d[3]),  0, 0)
    dataBuf.append(dbuf)

    dataTemp.append(int(arr[1]))
    datadTemp.append(int(arr[2]))
    dataWater.append(int(arr[3]))
    dataPressure.append(int(arr[4]))


if(data not in dataBuf):
    with open("Weather.txt", "a") as file:
        file.write("\n"+ data_text + ";" + Temp + ";" + dTemp + ";" + Water + ";"  + Pressure)

# Читаем данные из файла и строим график

fig, (ax1, ax2) = plt.subplots(nrows=2, ncols=1, figsize=(10, 8))
#ax1.imshow()
ax1.plot(dataBuf, dataTemp, 'o-r', alpha=0.7, label="first", lw=5, mec='b', mew=2, ms=10)
ax1.fill_between(dataBuf, dataTemp, color="g", alpha=0.3)
ax1.grid()
#ax1.xlabel("Время")
#ax1.ylabel("Температура ('C)")
#ax1.show()
ax1.set_title('Температура')
ax1.set_ylim(-40, 25)
#ax1.set_xlim(-50, 50)

#ax1.axis('off')

ax2.plot(dataBuf, dataPressure, 'o-b', alpha=0.7, label="first", lw=5, mec='b', mew=2, ms=10)
ax2.fill_between(dataBuf, dataTemp, color="g", alpha=0.2)
ax2.grid()
#ax1.xlabel("Время")
#ax1.ylabel("Температура ('C)")
#ax1.show()
ax2.set_title('Давление мм рт ст')
#ax4.axis('off')
ax2.set_ylim(720, 760)


"""
ax2.plot(dataBuf, datadTemp, 'o-b', alpha=0.7, label="first", lw=5, mec='b', mew=2, ms=10)
ax2.fill_between(dataBuf, dataTemp, color="g", alpha=0.2)
ax2.grid()
#ax1.xlabel("Время")
#ax1.ylabel("Температура ('C)")
#ax1.show()
ax2.set_title('dT')
#ax2.axis('off')

ax3.plot(dataBuf, dataWater, 'o-b', alpha=0.7, label="first", lw=5, mec='b', mew=2, ms=10)
ax3.fill_between(dataBuf, dataTemp, color="g", alpha=0.2)
ax3.grid()
#ax1.xlabel("Время")
#ax1.ylabel("Температура ('C)")
#ax1.show()
ax3.set_title('Влажность %')
#ax3.axis('off')

ax4.plot(dataBuf, dataWater, 'o-b', alpha=0.7, label="first", lw=5, mec='b', mew=2, ms=10)
ax4.fill_between(dataBuf, dataTemp, color="g", alpha=0.2)
ax4.grid()
#ax1.xlabel("Время")
#ax1.ylabel("Температура ('C)")
#ax1.show()
ax4.set_title('Давление мм рт ст')
#ax4.axis('off')

"""
fig.savefig("Weather.png")

print(0)






