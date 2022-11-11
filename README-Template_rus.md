# Немного о проекте

Приложение ТурБаза, создано для создания путёво в турагенстве, для облегчения работы в агенстве

---
[![Typing SVG](https://readme-typing-svg.herokuapp.com?color=%2336BCF7&lines=TyrBase)](https:gitio/typing-svg)
## Как начать
Во первых

1. Перейдите по ссылки прикрёплённой дальше 
[GitHub](https://github.com/SerHNey/ToursApp.git).
2. После нахождения на сайте, нажмите на кнопку ```Code```, как на скрине
    <details>
        <summary>Code</summary>
        <img alt="Code" src="https://i.ibb.co/6P1tHz2/image.png"/>
    </details>

3. Далее выбераем удобный нам способ установки проекта.
4. После того, как вы открыли проект через Visual Studio, вам необходимо собрать решение
    <details>
        <summary>Code</summary>
        <img alt="Сборка решения" src="https://i.ibb.co/gJrG6Cw/image.png"/>
    </details>
5. Готов

### Необходимые условия

1. Вам необходимо **последняя** версия Microsoft Visual Studio
   * Перейдите на **официальный сайт** Miscosoft
   * Скачайте нужную версию ___Microsoft Visual Studio___
       <details>
        <summary>Ms VS</summary>
        <img alt="Ms VS" src="https://i.ibb.co/WPQdJP1/image.png"/>
    </details>


   * Установить её

### Функции
- [X] Добавление нового отеля
``` C#
        private void BtdSave_Click_Hotels(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentHotel.Name))
                errors.AppendLine("Укажите название отеля");
            if (_currentHotel.CountOfStars < 1 || _currentHotel.CountOfStars > 5)
                errors.AppendLine("Укажите колличество звезд от 1 до 5");
            if (_currentHotel.Country == null)
                errors.AppendLine("Выберете страну");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentHotel.id == 0)
                Toursbase43PDSEntities.GetContext().Hotel.Add(_currentHotel);
            try
            {
                Toursbase43PDSEntities.GetContext().SaveChanges();
                MessageBox.Show("Запись добавленна");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
```
- [ ] Добавление новой страны
``` C#
        private void BtdSave_Click_Country(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentHotel.Name))
                errors.AppendLine("Укажите название страны");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            .... Доделать

        }
```


Завершите пример получением некоторых данных о сис  теме или использования их для небольшой демонстрации

## Контакт

* **SerHNey** - *Initial work* - [GitHub](https://github.com/SerHNey)
* Ссылка на проект: https://github.com/SerHNey/ToursApp.git

