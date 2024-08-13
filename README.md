# WWhite Dream Project Build

<p align="center"><img src="https://raw.githubusercontent.com/frosty-dev/ss14-wwdp/master/Resources/Textures/White/Logo/WWDPDarkSplashIcon.png" width="512px" /></p>

---

Einstein Engines - это хард форк [Space Station 14](https://github.com/space-wizards/space-station-14), построенный на идеалах и дизайнерском вдохновении семейства серверов BayStation 12 от Space Station 13 с упором на модульный код, который каждый может использовать для создания RP-сервера своей мечты.

Белая Мечта - один из основных серверов русского коммьюнити, который выступает за идеалы свободы отыгрыша, свободы слова и настоящей классической атмосферы Space Station 13 - хаос, веселье, возможности.

Space Station 14 это ремейк SS13, который работает на собственном движке [Robust Toolbox](https://github.com/space-wizards/RobustToolbox), написанном на C#.

Поскольку это хард форк, любой код, взятый из другого апстрима, не может быть напрямую слит сюда, а должен быть перенесен.
Весь код, представленный в этом репозитории, может быть изменен по желанию кодербаса Белой Мечты. 


## Ссылки

[Наш Discord](https://discord.station13.ru) | [Наша Вики](https://js.ss14.ru) | [Steam](https://store.steampowered.com/app/2585480/Space_Station_Multiverse/) | [Клиент без Steam](https://spacestationmultiverse.com/downloads/) | [Основной репозиторий](https://github.com/Simple-Station/Einstein-Engines)

## Контрибуция

Когда-нибудь.

## Сборка

Обратитесь к [руководству Space Wizards' guide](https://docs.spacestation14.com/en/general-development/setup/setting-up-a-development-environment.html) по настройке среды разработки для получения общей информации, но имейте в виду, что Einstein Engines - это не то же самое, и многие вещи могут быть неприменимы.
Мы предлагаем несколько скриптов, показанных ниже, чтобы облегчить работу.

### Депенденси

> - Git
> - .NET SDK 8.0.100


### Windows

> 1. Клонируйте этот репозиторий.
> 2. Используйте `git submodule update --init --recursive` в терминале, это скачает движок.
> 3. Используйте `Scripts/bat/buildAllDebug.bat` после любого изменения в сурсе.
> 4. Используйте `Scripts/bat/runQuickAll.bat` для запуска клиента и сервера.
> 5. Подключитесь к localhost, вы великолепны.

### Linux

> 1. Клонируйте этот репозиторий.
> 2. Используйте `git submodule update --init --recursive` в терминале, это скачает движок.
> 3. Используйте `Scripts/sh/buildAllDebug.sh` после любого изменения в сурсе.
> 4. Используйте  `Scripts/sh/runQuickAll.sh` для запуска клиента и сервера.
> 5. Подключитесь к localhost, вы великолепны.

### MacOS

> Сами тестируйте

## Лицензия

Содержимое, добавленное в этот репозиторий после коммита 87c70a89a67d0521a56388e6b1c3f2cb947943e4 (`17 февраля 2024 23:00:00 UTC`), распространяется по лицензии GNU Affero General Public License версии 3.0, если не указано иное.
См. [LICENSE-AGPLv3](./LICENSE-AGPLv3.txt).

Содержимое, добавленное в этот репозиторий после коммита 87c70a89a67d0521a56388e6b1c3f2cb947943e4 (`17 февраля 2024 23:00:00 UTC`), распространяется по лицензии MIT если не указано иное.
См. [LICENSE-MIT](./LICENSE-MIT.txt).

Большинство ресурсов лицензировано под [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/), если не указано иное. Лицензия и авторские права на ресурсах указаны в файле метаданных.
[Пример](./Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).

Ресурсы, которые были созданы командой White Dream лицензированы под [CC-BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/), если не указано иное. Лицензия и авторские права на ресурсах указаны в файле метаданных.
[Пример](./Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).

Обратите внимание, что некоторые активы лицензированы под некоммерческой [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) или аналогичной некоммерческой лицензией и должны быть удалены, если вы хотите использовать этот проект в коммерческих целях.