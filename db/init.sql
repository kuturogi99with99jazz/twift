-- テーブルの作成
CREATE TABLE IF NOT EXISTS sample_table (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    description TEXT
);

-- テーブル用データの挿入
INSERT INTO sample_table (name, description)
VALUES
    ('Sample Item 1', 'This is a sample item 1.'),
    ('Sample Item 2', 'This is a sample item 2.'),
    ('サンプル商品３', 'これはサンプル商品３です。');
