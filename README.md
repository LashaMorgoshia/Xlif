# Xlif



### First of all, we will write the i18n attribute on the elements in Angular and write the translation in the Description

< th scope="col" i18n="მიმართულება">Directions< / th >

![image](https://github.com/LashaMorgoshia/Xlif/assets/98417874/5a798535-5c6c-4154-95b3-ae470c4538af)

next step is extract resources from html files into .xlf file

`ng extract-i18n --output-path src/locale`
` ng extract-i18n  --build-target=MY_APP:build --output-path=src/locale`

![image](https://github.com/LashaMorgoshia/Xlif/assets/98417874/490f401c-db2f-4d57-b928-7a1b1c0858ce)


messages.xlf will be created

then run this:

`dotnet c:/xlif/xlif.dll src/locale/messages.xlf 'ka'`

![image](https://github.com/LashaMorgoshia/Xlif/assets/98417874/7a4197ea-f180-4bfe-87f0-2fa939117500)

