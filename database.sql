-- Active: 1794972999212@@127.0.0.1@3306@db_apotek_gudang
CREATE DATABASE IF NOT EXISTS db_apotek_gudang;
USE db_apotek_gudang;

DROP TABLE IF EXISTS tb_suplemen;
CREATE TABLE tb_suplemen (
    id_suplemen INT AUTO_INCREMENT PRIMARY KEY,
    kode_barang VARCHAR(20) NOT NULL UNIQUE,
    nama_barang VARCHAR(100) NOT NULL,
    kategori ENUM('Vitamin & Mineral', 'Herbal Sehat', 'Alat Kesehatan', 'Perawatan Luka') NOT NULL,
    stok INT NOT NULL,
    satuan VARCHAR(20) NOT NULL,
    harga_satuan INT NOT NULL,
    batas_minimum INT NOT NULL,
    terakhir_update TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Data Dummy Awal
INSERT INTO tb_suplemen (id_suplemen, kode_barang, nama_barang, kategori, stok, satuan, harga_satuan, batas_minimum) VALUES
(1, 'SPL-001', 'Vitamin C 500mg IPI Botol 45s', 'Vitamin & Mineral', 50, 'Botol', 12000, 20),
(2, 'SPL-002', 'Minyak Kayu Putih 120ml Cap Lang', 'Herbal Sehat', 8, 'Botol', 45000, 15),
(3, 'SPL-003', 'Tensimeter Digital Omron HEM-7120', 'Alat Kesehatan', 4, 'Unit', 420000, 5),
(4, 'SPL-004', 'Kasa Steril Husada 16x16 Box', 'Perawatan Luka', 35, 'Box', 15000, 10),
(5, 'SPL-005', 'Madu Murni Nusantara 250ml', 'Herbal Sehat', 12, 'Botol', 55000, 10);