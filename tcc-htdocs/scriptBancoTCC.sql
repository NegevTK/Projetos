create database FEMA_DATA_SYSTEM;
USE FEMA_DATA_SYSTEM;
CREATE TABLE DATA_SENSOR(
idColeta int primary key auto_increment,
valorUmidadeSolo varchar(10),
valorUmidade varchar(10),
valorTemperatura varchar(10),
sistemaLigado varchar(3),
dataColeta varchar(25)
);

DROP TABLE DATA_SENSOR;
select * from data_sensor;