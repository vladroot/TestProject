# TestProject
DI practice task

Player переименован в PlayerController.
PlayerController не является синглтоном и биндится в PlayerInstaller.
Изменение данных PlayerController возможно в любом классе, где конструктор получит интерфейс IPlayer.
PlayerIntstaller биндится в контексте сцены, т.о. PlayerController может быть в каждой сцене свой.
Уникальность PlayerController и его данных обеспечивается биндингом AsSingle.

Для работы с инвентарём добавлены дата классы Item, Weapon, RocketPack, Parachute и интерфейс IItem.
Для того, чтобы мможно было удобно добавлять в проект новые предметы также добавлены классы ItemScriptable, GenericItemScriptable и их наследники.
Создаваемые скриптабл объекты легко добавлять в качестве параметров в инспекторе, как продемострировано в InventorySettings,
также их можно использовать для графов визуального скриптинга гейм дизайнерами.
