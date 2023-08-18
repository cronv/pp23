import mysql.connector
import pandas as pd
import matplotlib.pyplot as plt

# Подключение к базе данных MySQL
mydb = mysql.connector.connect(
  host="mysql8",
  user="root",
  password="12345678",
  database="db_analyse"
)

# Чтение данных из таблицы в базе данных
def read_data_from_mysql():
    query = "SELECT * FROM sales"
    df = pd.read_sql(query, mydb)
    return df

# Фильтрация данных по определенному условию
def filter_data(df, condition):
    filtered_df = df[df['product'] == condition]
    return filtered_df

# Группировка данных по категории и выполнение агрегации
def group_and_aggregate_data(df):
    grouped_df = df.groupby('category').agg({'quantity': 'sum', 'price': 'mean'})
    return grouped_df

# Визуализация результатов анализа
def visualize_data(df):
    df.plot(kind='bar', y='quantity', legend=False)
    plt.ylabel('Quantity')
    plt.show()

# Функция для ввода пользователем условия фильтрации и выполнения анализа
def user_input_and_analysis():
    df = read_data_from_mysql()
    print('Data:')
    print(df)
    condition = input('Enter a product to filter: ')
    filtered_df = filter_data(df, condition)
    print('Filtered Data:')
    print(filtered_df)
    grouped_df = group_and_aggregate_data(filtered_df)
    print('Grouped and Aggregated Data:')
    print(grouped_df)
    visualize_data(grouped_df)

user_input_and_analysis()
