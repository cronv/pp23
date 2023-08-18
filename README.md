Программа предлагает пользователю ввести условие фильтрации по продукту, а затем фильтрует данные, группирует их по
категории и выполняет агрегацию для колонок "quantity" и "price".

Результаты анализа визуализируются в виде столбчатой диаграммы.

Docker Display: Xming X Server

Сборка
```ps
docker build . -t python_slim
```

Запуск
```ps
docker run -it --network case2_default python_slim python analyse.py
```