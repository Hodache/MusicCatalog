# Music Catalog

## Комментарии
Чтобы придумать классовую модель каталога, смотрел как устроена Яндекс Музыка.  
Было интересно использовать MVVM и EF, раньше не работал, поэтому хромает исполнение)  
Применил паттерны Команда и Медиатор (файлы лежат в папке Services)  

## Поля и связи между классами:
![image](https://github.com/user-attachments/assets/0f2bf08c-a3cb-4936-a478-5a5b9de85f94)

## Схема БД
![image](https://github.com/user-attachments/assets/b6726706-42ff-436b-89a5-cffdb2c636fb)

На самом деле, еще существет таблица MusicCollections (так сделал EF).

## Описание окон

Основное окно

![image](https://github.com/user-attachments/assets/377e81f2-49ba-4d84-9466-81960e77f9bc)

Для поиска необходимо выставить фильтры, ввести поисковый запрос и нажать Поиск.  
Поиск ведется одновременно по артистам, трекам, альбомам (в отдельную категорию выделяются синглы), плейлистам.  
В результаты поиска попадают объекты, в названии которых в любом месте содержится поисковый запрос.  

Фильтры
  Жанр  
    Для артистов - отбирает артистов, имеющих хотя бы 1 альбом с указанным жанром  
    Для треков - отбирает треки, включенные хотя бы в 1 альбом с указанным жанром  
    Для альбомов - отбирает альбомы с указанным жанром  
    Для плейлистов - не влияет  
  Год  
    Для артистов - отбирает артистов, выпустивших хотя бы 1 альбом в указанный период  
    Для треков - отбирает треки, включенные хотя бы в 1 альбом, выпущенный в указанный период  
    Для альбомов - включает альбомы, выпущенные в указанный период  
    Для плейлистов - включает плейлисты, последнее обновление которого произошло в указанный период  
  Длительность  
    Для треков - включает треки, длительность которых в указанном промежутке  
    Для остального - не работает  

Чтобы открыть окно с деталями по найденному объекту, нужно сделать 2-й клик на соответствующую строку в результатах поиска.

![image](https://github.com/user-attachments/assets/5f55bde8-dad1-4d21-9b5b-035519accd55)

Детали объекта каталога  
  Тип объекта  
  Название объекта (имя артиста, название трека, альбома, плейлиста)  
  Доп инфо 1 (страна артиста, артисты-авторы трека, альбома, описание плейлиста)  
  Доп инфо 2 (статус артиста, длительность трека, год и жанр альбома, дата последнего обновления плейлиста)  
  Связанные объекты (выпущенные артистом альбомы, альбомы содержащие трек, вошедшие в альбом или плейлист треки)  

Для создания объектов нужно нажать на одну из кнопок в блоке Создание.  

Окно создания артиста

![image](https://github.com/user-attachments/assets/98f8c2a7-ba57-4142-b224-86d8027564f8)

Нужно заполнить имя, страну артиста, выбрать статус (активен/неактивен) и нажать на Создать.

Окно создания жанра

![image](https://github.com/user-attachments/assets/c02455c6-35f1-480b-9b4b-d2e6e3edf24a)

Нужно заполнить название жанра и нажать на Создать.

Окно создания альбома

![image](https://github.com/user-attachments/assets/213edf4f-5b42-4c2e-9d5c-2c8e79fd92a5)

Нужно заполнить название, выбрать артиста, дату, жанр альбома, включить в него треки и нажать на Создать.  
Треки можно включать 2-х типов: новые и уже существующие.  
  
Чтобы создать и добавить новый трек, нужно открыть окно создания нового трека нажатием на кнопку Новый.

![image](https://github.com/user-attachments/assets/39c99716-fe4c-42dc-b4a9-2f91c2c236bf)

В окне заполнить название трека, его длительность в секундах, добавить артистов-авторов и нажать кнопку Создать и добавить.  
Для добавления артиста нужно выбрать его в выпадающем меню и нажать кнопку Добавить выбранного.  
После добавления трека в альбом, если ему не присвоен артист альбома, он будет присвоен автоматически.  
  
Чтобы добавить уже существующий трек, нужно открыть окно нажатием на кнопку Сущ-ий.

![image](https://github.com/user-attachments/assets/03523a1b-408d-46b7-9dcd-c776db9a9348)

В окне можно поочередно добавить множество треков.  
Чтобы добавить трек, нужно ввести его название в поле (можно частично) и выбрать его из выпадающего меню, затем нажать Добавить.  
Возможно добавить только треки, среди авторов которых есть артист, выбранный в окне создания альбома  
После изменения артиста в окне создания альбома, все треки, не имеющие нового артиста среди своих авторов будут удалены из списка.  

Окно создания плейлиста
![image](https://github.com/user-attachments/assets/4a73ed04-34c8-4d4c-817c-ca2c78636fdb)

Нужно заполнить название, описание, дату последнего обновления плейлиста, включить в него треки и нажать на Создать.
Добавление треков в плейлист аналогично добавлению существующих треков в альбом.
