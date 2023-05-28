# Dockerfile

# ベースイメージとして最新版のPostgreSQLを設定
FROM postgres:latest

# パッケージリストを更新し、localesパッケージをインストール
RUN apt-get update && apt-get install -y locales

# イメージ内で日本語ロケールを有効化し、ロケールを生成
RUN sed -i -e 's/# ja_JP.UTF-8 UTF-8/ja_JP.UTF-8 UTF-8/' /etc/locale.gen && \
    locale-gen
