# Введение 
Реализация проекта создания консольной игры для выполнения требований курса "Технологии программирования" 2-го семестра, первого курса МФТИ ФПМИ ПМФ КТ.
Для реализации выбрана игра жанра "Wargame" - "Battle for Moscow" © [Frank Chadwick][i1] 1986

[i1]: https://en.wikipedia.org/wiki/Frank_Chadwick

# Задание 1
Этап создания игровых персонажей (юнитов)
В данной игре не предусмотрено пользовательское создание персонажей, все фишки (3 типов) предопределены заранее и загружены в виде json файла.
Так же на данном этапе реализована игровое поле, состоящее из клеток, которые обладают набором свойств.

# Сборка и запуск
## Windows
1.	Установить .NET 5.0 SDK [x64](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.201-windows-x64-installer) | [x86](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.201-windows-x86-installer)
2.	Клонировать репозиторий
3.	Собрать и запустить проект, для этого из корневого каталога репозитория выполнить команду:
```
    dotnet run --project BattleForMoscow
```

## Linux
1.	Установить [.NET 5.0 SDK](https://docs.microsoft.com/ru-ru/dotnet/core/install/linux)
> На примере Ubuntu 20.04
> 1. Добавить сертификат Microsoft в список доверенных сертификатов
> ``` 
> wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
> sudo dpkg -i packages-microsoft-prod.deb
> ```
> 2. Установить собственно SDK
> ```
>sudo apt-get update; \
>  sudo apt-get install -y apt-transport-https && \
>  sudo apt-get update && \
>  sudo apt-get install -y dotnet-sdk-5.0
> ```
> **Важно**!
> Если вы получили сообщение об ошибке похожее на **Unable to locate package dotnet-sdk-5.0** то обратитесь к разделу: [APT troubleshooting](https://docs.microsoft.com/ru-ru/dotnet/core/install/linux-ubuntu#apt-troubleshooting)

2.	Клонировать репозиторий
3.	Собрать и запустить проект, для этого из корневого каталога репозитория выполнить команду:
```
    dotnet run --project BattleForMoscow
```

