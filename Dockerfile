FROM python:slim

WORKDIR /app
COPY app /app
VOLUME /app/data

RUN chmod 777 /app

RUN pip install numpy mysql-connector-python pandas matplotlib
RUN python -c "import matplotlib.pyplot"

CMD [ "python" ]
