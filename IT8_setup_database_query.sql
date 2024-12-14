CREATE DATABASE IT8_PROJECT_DATABASE
USE IT8_PROJECT_DATABASE

CREATE TABLE KHACHHANG
(
    USERNAME VARCHAR(20) NOT NULL,
    PASSWRD VARCHAR(20) NOT NULL,
    TENKH VARCHAR(60) NOT NULL,
    EMAIL VARCHAR(60) NOT NULL,
    SDT VARCHAR(10) NOT NULL,
    GTINH BIT NOT NULL,
    CONSTRAINT CS_PK_KHACHHANG PRIMARY KEY(USERNAME)
)
CREATE TABLE LOAITHETHAO
(
    MALOAITT VARCHAR(10) NOT NULL,
    TENLOAITT VARCHAR(15) NOT NULL,
    CONSTRAINT CS_PK_LOAITHETHAO PRIMARY KEY(MALOAITT)
)
CREATE TABLE SANTHETHAO
(
    MASANTT VARCHAR(10) NOT NULL,
    MALOAITT VARCHAR(10) NOT NULL,
    TENSANTT VARCHAR(15) NOT NULL,
    GTSANG MONEY NOT NULL,
    GTTRUA MONEY NOT NULL,
    GTTOI MONEY NOT NULL,
    CONSTRAINT CS_PK_SANTHETHAO PRIMARY KEY(MASANTT)
)
CREATE TABLE HOADON
(
    MAHD VARCHAR(10) NOT NULL,
    USERNAME VARCHAR(20) NOT NULL,
    NGTTOAN SMALLDATETIME NOT NULL,
    TRIGIA MONEY NOT NULL,
    CONSTRAINT CS_PK_HOADON PRIMARY KEY(MAHD)
)
CREATE TABLE CTHD
(
    MAHD VARCHAR(10) NOT NULL,
    MASANTT VARCHAR(10) NOT NULL,
    NGHDHLUC SMALLDATETIME NOT NULL,
    TTGTSANG BINARY(4) NOT NULL,
    TTGTTRUA BINARY(4) NOT NULL,
    TTGTTOI BINARY(4) NOT NULL,
    CONSTRAINT CS_PK_CTHD PRIMARY KEY(MAHD, MASANTT)
)

ALTER TABLE SANTHETHAO 
ADD CONSTRAINT PK_LOAITHETHAO_TO_FK_SANTHETHAO 
FOREIGN KEY(MALOAITT) REFERENCES LOAITHETHAO(MALOAITT)

ALTER TABLE HOADON
ADD CONSTRAINT PK_KHACHHANG_TO_FK_HOADON
FOREIGN KEY(USERNAME) REFERENCES KHACHHANG(USERNAME)

ALTER TABLE CTHD
ADD CONSTRAINT PK_HOADON_TO_FK_CTHD
FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD)

ALTER TABLE CTHD
ADD CONSTRAINT PK_SANTHETHAO_TO_FK_CTHD
FOREIGN KEY(MASANTT) REFERENCES SANTHETHAO(MASANTT)

ALTER TABLE SANTHETHAO
ALTER COLUMN TENSANTT VARCHAR(50) NOT NULL

ALTER TABLE KHACHHANG
ALTER COLUMN SDT VARCHAR(15) NOT NULL

ALTER TABLE KHACHHANG 
ADD LOAI VARCHAR(10)

ALTER TABLE KHACHHANG
ADD CONSTRAINT chk_customerType
CHECK (LOAI IN('admin', 'normal'))





