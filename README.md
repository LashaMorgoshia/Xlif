# Xlif



First of all, we will write the i18n attribute on the elements in Angular and write the translation in the Description

< th scope="col" i18n="მიმართულება">Directions< / th >

![image](https://github.com/LashaMorgoshia/Xlif/assets/98417874/5a798535-5c6c-4154-95b3-ae470c4538af)

next step is extract resources from html files into .xlf file

ng extract-i18n --output-path src/locale

a messages.xlf file will be created

then we run this command

dotnet c:/xlif/xlif.dll src/locale/messages.xlf 'ka'
