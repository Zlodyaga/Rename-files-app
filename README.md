# Rename files app

## Описание
Rename-files-app — это программа на C# (Windows Forms), предназначенная для пакетного переименования файлов по заданному шаблону. Вы указываете исходный шаблон имени с символом `#` вместо номера серии, а также желаемый формат нового имени. Программа автоматически заменяет `#` на найденные номера серий и переименовывает файлы в указанной папке.

## Возможности
- Выбор папки с файлами для переименования.
- Использование маски с `#` для автоматической подстановки номера серии (поддерживаются числа от 1 до 4 цифр).
- Безопасное переименование с проверкой корректности имён.

## Установка и запуск
1. Убедитесь, что у вас установлена .NET Framework 4.7.2 или выше.
2. Скачайте и запустите исполняемый файл `FileRenamer.exe`.
3. Выберите папку с файлами, введите исходный и новый шаблон именования.
4. Нажмите "Предварительный просмотр" для проверки какие файлы видны.
5. Нажмите "Переименовать" для окончательного изменения имен файлов.

## Формат шаблонов
- **Исходный шаблон**: `[SubsPlus+] Oshi No Ko S2 - # [WEB-DL 1080p x264 DDP].mkv`
- **Новый шаблон**: `[VCB-Studio] OSHI NO KO.S01E#. [BDRip 1080p x265 FLAC].mkv`
- Символ `#` заменяется на номер серии (например, `01`, `1`, `1572`).
