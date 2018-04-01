FROM alpine
RUN apk add --update \
    python \
    python-dev \
    py-pip
RUN pip install flask
COPY hello.py /
EXPOSE 5000
ENTRYPOINT ["python","hello.py"]
