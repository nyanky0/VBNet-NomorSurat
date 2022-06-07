-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 12 Jan 2022 pada 08.44
-- Versi server: 10.4.21-MariaDB
-- Versi PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbnomorsurat`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_jenissurat`
--

CREATE TABLE `tbl_jenissurat` (
  `panjang` varchar(50) NOT NULL,
  `singkat` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_jenissurat`
--

INSERT INTO `tbl_jenissurat` (`panjang`, `singkat`) VALUES
('MOU', 'MOU'),
('PERINTAH KERJA', 'SPK'),
('PERJANJIAN KERJA TETAP', 'SPKT'),
('PERJANJIAN KONTRAK KERJA', 'SPKK'),
('SURAT KELUAR', 'KL');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_nosurat`
--

CREATE TABLE `tbl_nosurat` (
  `no` varchar(10) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `nosurat` varchar(50) NOT NULL,
  `instansi` varchar(50) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_nosurat`
--

INSERT INTO `tbl_nosurat` (`no`, `tanggal`, `nosurat`, `instansi`, `keterangan`) VALUES
('001', '2022-01-11 14:33:13', '001/SEKDIR-KL-PHN/I/2022', 'A', 'A'),
('001', '2022-01-10 15:06:43', '001/SEKDIR-MOU-PHN/I/2022', 'TES 1', '1'),
('001', '2022-01-10 15:07:30', '001/SEKDIR-SPK-PHN/I/2022', 'TES 3', '3'),
('002', '2022-01-10 15:07:22', '002/SEKDIR-MOU-PHN/I/2022', 'TES 2', '2'),
('003', '2022-01-11 15:42:23', '003/SEKDIR-MOU-PHN/I/2022', '3', '3');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_nosurat2022`
--

CREATE TABLE `tbl_nosurat2022` (
  `no` varchar(10) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `nosurat` varchar(50) NOT NULL,
  `instansi` varchar(50) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_nosurat2022`
--

INSERT INTO `tbl_nosurat2022` (`no`, `tanggal`, `nosurat`, `instansi`, `keterangan`) VALUES
('001', '2022-01-11 14:33:13', '001/SEKDIR-KL-PHN/I/2022', 'A', 'A'),
('001', '2022-01-10 15:06:43', '001/SEKDIR-MOU-PHN/I/2022', 'TES 1', '1'),
('001', '2022-01-10 15:07:30', '001/SEKDIR-SPK-PHN/I/2022', 'TES 3', '3'),
('002', '2022-01-10 15:07:22', '002/SEKDIR-MOU-PHN/I/2022', 'TES 2', '2'),
('003', '2022-01-11 15:42:23', '003/SEKDIR-MOU-PHN/I/2022', '3', '3');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_organisasi`
--

CREATE TABLE `tbl_organisasi` (
  `panjang` varchar(50) NOT NULL,
  `singkat` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_organisasi`
--

INSERT INTO `tbl_organisasi` (`panjang`, `singkat`) VALUES
('RS ONKOLOGI SOLO', 'RSOS'),
('PERMATA HARAPAN NUSANTARA', 'PHN');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_jenissurat`
--
ALTER TABLE `tbl_jenissurat`
  ADD PRIMARY KEY (`panjang`);

--
-- Indeks untuk tabel `tbl_nosurat`
--
ALTER TABLE `tbl_nosurat`
  ADD PRIMARY KEY (`nosurat`);

--
-- Indeks untuk tabel `tbl_nosurat2022`
--
ALTER TABLE `tbl_nosurat2022`
  ADD PRIMARY KEY (`nosurat`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
