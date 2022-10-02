-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 02, 2022 at 12:04 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ckp_music`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `username` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`username`, `password`) VALUES
('admin', '13022026');

-- --------------------------------------------------------

--
-- Table structure for table `customerinfo`
--

CREATE TABLE `customerinfo` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `surname` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `address` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `tel` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `username` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `customerinfo`
--

INSERT INTO `customerinfo` (`id`, `name`, `surname`, `address`, `tel`, `email`, `username`, `password`) VALUES
(50, 'ชนาธิป', 'เคนทรภักด์', 'มหาวิทยาลัยขอนแก่น', '0653196397', 'chanathip_kh@kkumail.com', 'chnt1302', '13022026'),
(53, 'ชาคริต', 'ทิพวัฒน์', '555/63 ต.เมืองเก่า อ.เมือง จ.ขอนแก่น', '0930592001', 'chakhrit.th@kkumail.com', 'joji_000', '12348765a'),
(61, 'ชาคริส', 'เคนทรภักดิ์', '55 ม.8 บ.ผักหนาม ต.หนองกุงใหญ่ อ.กระนวน จ.ขอนแก่น 40170', '0934300137', 'khen_tarapag@hotmail.com', 'chakrit1619', '161919'),
(62, 'ชาคริส', 'เคนทรภักดิ์', 'มหาวิทยาลัยมหาสารคาม', '0934300137', 'chakrit_khentarapag@kkumail.com', 'chakrit1619', '161919'),
(64, 'ณัฐชนน', 'สินเจริญเลิศ', '435/8 ต.หมากแข้ง อ.เมือง จ.อุดรธานี 41000', '0851632706', 'nutchanon_sincharoenlert@kkumail.com', 'Maple', '123456789m');

-- --------------------------------------------------------

--
-- Table structure for table `history`
--

CREATE TABLE `history` (
  `id` int(11) NOT NULL,
  `username` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `product` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `amount` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `date` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `history`
--

INSERT INTO `history` (`id`, `username`, `product`, `amount`, `price`, `date`) VALUES
(645, 'b', 'Fender Modern Jazzmaster', 1, 49500, '14/09/2565'),
(646, 'b', 'Fender CD-60SCE Acoustic', 1, 10800, '14/09/2565'),
(649, 'chnt1302', 'Fender American Original 50 Stratocaster', 1, 72000, '15/09/2565'),
(650, 'chnt1302', 'Fender American Original 50 Stratocaster', 1, 72000, '15/09/2565'),
(651, 'chnt1302', 'Fender 75th Anniversary Stratocaster', 1, 31500, '15/09/2565'),
(652, 'chnt1302', 'Fender GB Hot Rod Deluxe™ ', 1, 39600, '15/09/2565'),
(653, 'chnt1302', 'Fender 75th Anniversary Stratocaster', 1, 31500, '15/09/2565'),
(654, 'chnt1302', 'Fender 75th Anniversary Stratocaster', 1, 31500, '15/09/2565'),
(662, 'chnt1302', 'Gibson Les Paul Standard ’60s', 1, 85500, '20/09/2565'),
(663, 'chnt1302', 'Fender Duff Mckagan Deluxe ', 1, 45000, '20/09/2565'),
(664, 'chnt1302', 'Line 6 Catalyst 100 ', 1, 17900, '20/09/2565'),
(665, 'chnt1302', 'Boss MT-2 Metal Zone Distortion ', 1, 3360, '20/09/2565'),
(666, 'chnt1302', 'Fender 75th Anniversary Stratocaster', 1, 31500, '02/10/2565'),
(667, 'chnt1302', 'Fender Acoustasonic 40 ', 1, 8550, '02/10/2565');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `username` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `username`, `password`) VALUES
(31, 'chnt1302', '13022026'),
(32, 'joji_000', '12348765a'),
(40, 'chakrit1619', '161919'),
(42, 'Maple', '123456789m'),
(43, 'Maple', '123456789m');

-- --------------------------------------------------------

--
-- Table structure for table `shopping_cart`
--

CREATE TABLE `shopping_cart` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `amount` int(11) NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `id` int(11) NOT NULL,
  `product` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `brand` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `type` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `price` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `pathimage` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`id`, `product`, `brand`, `type`, `price`, `amount`, `pathimage`) VALUES
(34, 'Fender 75th Anniversary Stratocaster', 'Fender', 'Stratocaster', 31500, 98, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender 75th Anniversary Stratocaster.jpg'),
(36, 'Fender American Original 50 Stratocaster', 'Fender', 'Stratocaster', 72000, 100, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender American Original 50 Stratocaster.jpg'),
(37, 'Fender 75th Anniversary Telecaster', 'Fender', 'Telecaster', 31500, 100, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender 75th Anniversary Telecaster.jpg'),
(38, 'Fender American QMT Telecaster Pale Moon', 'Fender', 'Telecaster', 81000, 100, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender American QMT Telecaster Pale Moon.jpg'),
(39, 'Fender Modern Jazzmaster', 'Fender', 'Jazzmaster', 49500, 100, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Modern Jazzmaster.jpg'),
(40, 'Fender Noventa Jazzmaster', 'Fender', 'Jazzmaster', 40500, 100, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Noventa Jazzmaster.jpg'),
(41, 'Fender CD-60SCE Acoustic', 'Fender', 'Acoutic', 10800, 100, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender CD-60SCE Acoustic.jpg'),
(42, 'Fender FA-125CE Dreadnought', 'Fender', 'Acoutic', 7200, 100, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender FA-125CE Dreadnought.jpg'),
(43, 'Gibson Les Paul Standard ’60s', 'Gibson', 'Les paul', 85500, 99, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\GS-STD60-LP-UB-02.jpg'),
(44, 'Gibson Les Paul Faded 2017', 'Gibson', 'Les paul', 29700, 100, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\lp fade.jpg'),
(45, 'Gibson Explorer', 'Gibson', 'Explorer', 58500, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Gibson Explorer.jpg'),
(46, 'Gibson Explorer T', 'Gibson', 'Explorer', 47700, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Gibson Explorer T.jpg'),
(47, 'ES-335 Rose Tattoo 1959', 'Gibson', 'es', 216000, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Gibson Es335.jpg'),
(48, 'ES-339', 'Gibson', 'es', 99000, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Gibson Es339.jpg'),
(49, 'SG Faded 2017 T', 'Gibson', 'sg', 29700, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\SG faded.jpg'),
(50, 'SG standard', 'Gibson', 'sg', 52200, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\SG standard.jpg'),
(51, 'Gibson J-45 Studio Rosewood', 'Gibson', 'Acoutic', 81000, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Gibson J-45 Studio Rosewood.jpg'),
(52, 'Gibson 1942 banner j-45', 'Gibson', 'Acoutic', 157700, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\eee.jpg'),
(72, 'RockBass Corvette ', 'Warwick', '4 String', 22400, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\RockBass Corvette Bass 4 Strings 22,400.png'),
(73, 'Rockbass Infinity ', 'Warwick', '4 String', 24000, 8, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Rockbass Infinity Bass 4 Strings 24,000.png'),
(74, 'Rockbass Racing Stripes Streamer ', 'Warwick', '4 String', 12300, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Rockbass Racing Stripes Streamer 12,300.png'),
(75, 'Rockbass Streamer NT ', 'Warwick', '4 String', 26400, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Rockbass Streamer NT Bass 4 Strings 26,400.png'),
(76, 'Rockbass Corvette Basic ', 'Warwick', '5 String', 22400, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Rockbass Corvette Basic 5 Strings 22,400.png'),
(77, 'Rockbass Racing Stripes ', 'Warwick', '5 String', 16800, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Rockbass Racing Stripes Corvette 5 16,800.png'),
(78, 'Rockbass Streamer NT ', 'Warwick', '5 String', 28000, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Rockbass Streamer NT Bass 5 Strings 28,000.png'),
(79, 'Rockbass Streamer Standard ', 'Warwick', '5 String', 17200, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Rockbass Streamer Standard Bass 5 Strings 17,200.png'),
(80, 'Blackstar Fly 3 Acoustic ', 'Blackstar', 'Amp', 2880, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Blackstar Fly 3 Acoustic 2880.png'),
(81, 'Blackstar HT Club 40 MKII ', 'Blackstar', 'Amp', 31500, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Blackstar HT Club 40 MKII 31500.png'),
(82, 'Blackstar HT Club 40 MkII Blonde ', 'Blackstar', 'Amp', 31500, 8, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Blackstar HT Club 40 MkII Blonde Special Editions 31500.png'),
(83, 'Blackstar HT Stage 60 212 MkII ', 'Blackstar', 'Amp', 43200, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Blackstar HT Stage 60 212 MkII 43200.png'),
(84, 'Boss Katana 50 ', 'Boss', 'Amp', 7600, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Boss Katana 50 7600 (1).png'),
(85, 'Boss Katana Artist MKII ', 'Boss', 'Amp', 20000, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Boss Katana Artist MKII 20000.png'),
(86, 'Boss Katana-100212MkII ', 'Boss', 'Amp', 18400, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Boss Katana-100212MkII 18400.png'),
(87, 'Boss Nextone Artist ', 'Boss', 'Amp', 24000, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Boss Nextone Artist 24000.png'),
(88, 'Fender ’59 Bassman Blonde ', 'Fender', 'Amp', 69300, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender ’59 Bassman Blonde Limited Edition 69300.png'),
(89, 'Fender 64 Custom Deluxe ', 'Fender', 'Amp', 103500, 8, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender ’64 Custom Deluxe Reverb 103500.png'),
(90, 'Fender Acoustasonic 40 ', 'Fender', 'Amp', 8550, 8, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Acoustasonic 40 8550.png'),
(91, 'Fender GB Hot Rod Deluxe™ ', 'Fender', 'Amp', 39600, 8, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender GB Hot Rod Deluxe™ (George Benson) 39600.png'),
(92, 'Fender Tone Master Deluxe Reverb ', 'Fender', 'Amp', 36000, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Tone Master Deluxe Reverb Blonde.png'),
(93, 'Line 6 Catalyst 100 ', 'Line6', 'Amp', 17900, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Line 6 Catalyst 100 17900.png'),
(94, 'Line 6 Spider iv15 ', 'Line6', 'Amp', 5490, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Line 6 Spider iv15 5490.png'),
(95, 'Line 6 Spider V 60 MKII ', 'Line6', 'Amp', 12900, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Line 6 Spider V 60 MKII 12900.png'),
(96, 'Line 6 Spider V 120 MKII ', 'Line6', 'Amp', 16500, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Line 6 Spider V 120 MKII 16500.png'),
(97, 'Boss DD-6 Digital Delay ', 'Delay', 'Effect', 5600, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Boss DD-6 Digital Delay 5600.png'),
(98, 'Flamma FC03 Guitar Delay  ', 'Delay', 'Effect', 1290, 7, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Flamma FC03 Guitar Delay Pedal Analog Real Echo Tape Echo 1290.png'),
(99, 'Flamma FS03 Stereo Delay ', 'Delay', 'Effect', 2590, 7, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Flamma FS03 Stereo Delay 2590.png'),
(100, 'Flamma FS22 Ekoverb Dual Reverb Delay ', 'Delay', 'Effect', 2990, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Flamma FS22 Ekoverb Guitar Stereo Dual Reverb Delay Effects Pedal 2990.png'),
(101, 'Jim Dunlop MXR M169A Delay ', 'Delay', 'Effect', 7225, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Jim Dunlop MXR M169A Carbon Copy Analog Delay 10th Anniversary Edition 7225.png'),
(102, 'Boss DS-1 distortion ', 'Distortion', 'Effect', 1760, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Boss DS-1 distortion 1760.png'),
(103, 'Boss MT-2 Metal Zone Distortion ', 'Distortion', 'Effect', 3360, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Boss MT-2 Metal Zone Distortion 3360.png'),
(104, 'NUX Recto Distortion ', 'Distortion', 'Effect', 1260, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\NUX Recto Distortion 1260.png'),
(105, 'NUX NDD-6 Dual Delay ', 'Delay', 'Effect', 3960, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\NUX NDD-6 duotime Dual Delay Engine 3960.png'),
(106, 'Tech 21 SansAmp Boost Distortion ', 'Distortion', 'Effect', 5300, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Tech 21 SansAmp Boost Distortion Metallic 5300.png'),
(107, 'Boss SD-1W Super OverDrive ', 'Over Drive', 'Effect', 5600, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Boss SD-1W Super OverDrive Waza Craft 5600.png'),
(109, 'WALRUS AUDIO 385 OVERDRIVE ', 'Over Drive', 'Effect', 6900, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\WALRUS AUDIO 385 OVERDRIVE 6900.png'),
(110, 'WALRUS AUDIO Ages Five-State Overdrive', 'Over Drive', 'Effect', 6900, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\WALRUS AUDIO Ages Five-State Overdrive 6900.png'),
(111, 'Fender Tre-Verb Digital Reverb', 'Reverb', 'Effect', 8500, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Tre-Verb Digital ReverbTremolo 8500.png'),
(112, 'Flamma FC03 Guitar Reverb Pedal', 'Reverb', 'Effect', 1290, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Flamma FC03 Guitar Reverb Pedal 1290.png'),
(113, 'Jim Dunlop CSP036 IL Diavolo Overdrive', 'Over Drive', 'Effect', 5100, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Jim Dunlop CSP036 IL Diavolo Overdrive 5100.png'),
(114, 'TC Electronic Fluorescence Reverb', 'Reverb', 'Effect', 3800, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\TC Electronic Fluorescence Shimmer Reverb 3800.png'),
(116, 'Boss PW-3 Wah Pedal ', 'Wah Wah', 'Effect', 4400, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Boss PW-3 Wah Pedal 4400.png'),
(117, 'Hotone Vow Press Switchable Volume', 'Wah Wah', 'Effect', 3800, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Hotone Vow Press Switchable Volume Wah Pedal 3800.png'),
(119, 'Vox V846-HW Wah Pedal ', 'Wah Wah', 'Effect', 7200, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Vox V846-HW Wah Pedal 7200.png'),
(120, 'Boss TU-02 Clip-On Tuner ', 'Tuner', 'Effect', 400, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Boss TU-02 Clip-On Tuner 400.png'),
(121, 'Boss TU-05 Clip-On Tuner', 'Tuner', 'Effect', 800, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Boss TU-05 Clip-On Tuner 800.png'),
(122, 'Hotone STU-1 Hotone Smart Tiny Tuner', 'Tuner', 'Effect', 1990, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Hotone STU-1 Hotone Smart Tiny Tuner LED Guitar Pedal 1990.png'),
(123, 'Mooer Baby Tuner – Tuner pedal ', 'Tuner', 'Effect', 2400, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Mooer Baby Tuner – Tuner pedal 2400.png'),
(124, 'NUX NTU-2 HD Pitch Mini Pedal Tuner ', 'Tuner', 'Effect', 1350, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\NUX NTU-2 HD Pitch Mini Pedal Tuner 1350.png'),
(125, 'CIOKS Power Factor 2 Link  ', 'Power supply', 'Effect', 9600, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\CIOKS Power Factor 2 Link – 8 Isolated Outlets 9 And 12V DC 9600.png'),
(126, 'Fender Engine Room LVL12 ', 'Power supply', 'Effect', 9000, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Engine Room LVL12 Power Supply 9000.png'),
(127, 'Jim Dunlop MXR M238 ISO-Brick ', 'Power supply', 'Effect', 6375, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Jim Dunlop MXR M238 ISO-Brick Power Supply 6375.png'),
(128, 'RockBoard Power Pit ', 'Power supply', 'Effect', 4500, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\RockBoard Power Pit Multi-Power Supply 4500.png'),
(129, 'Astro Pro Strap ', 'Strap', 'Other', 600, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\_Astro Pro Strap 600.png'),
(130, 'ERNIE BALL STRETCH COMFORT RACER', 'Strap', 'Other', 800, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\ERNIE BALL STRETCH COMFORT RACER WHITE STRAP 800.png'),
(131, 'Fender 2 Modern Tweed', 'Strap', 'Other', 810, 8, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender 2 Modern Tweed Strap 810.png'),
(132, 'Fender 2” Monogrammed ', 'Strap', 'Other', 630, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender 2” Monogrammed Straps 630.png'),
(133, 'D’Addario Black Ice Pick ', 'Pick & Capo', 'Other', 20, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\D’Addario Black Ice Pick 20.png'),
(134, 'D’Addario Celluloid Thumb Pick ', 'Pick & Capo', 'Other', 25, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\D’Addario Celluloid Thumb Pick 25.png'),
(135, 'Jim Dunlop Tosin Abasi Tortex Jazz III XL', 'Pick & Capo', 'Other', 200, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Jim Dunlop Tosin Abasi Tortex Jazz III XL Pick 3pcs 200.png'),
(136, 'Jim Dunlop Animals Leaders Primetone', 'Pick & Capo', 'Other', 270, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Jim Dunlop Animals AS Leaders Brown Primetone Pick 3pcs 270.png'),
(137, 'Joe Satriani Picks ( 1 set = 10 Picks )', 'Pick & Capo', 'Other', 220, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Joe Satriani Picks ( 1 set = 10 Picks ) 220.png'),
(138, 'D’Addario CP-04 NS Classical Capo Pro', 'Pick & Capo', 'Other', 600, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\D’Addario CP-04 NS Classical Capo Pro 600.png'),
(139, 'SHUBB C2 Capo ', 'Pick & Capo', 'Other', 820, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\SHUBB C2 Capo 820.png'),
(140, 'Ernie Ball Burly Slinky 11-52 ', 'Cable & String', 'Other', 180, 11, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Ernie Ball Burly Slinky 11-52 180.png'),
(141, 'D’Addario XSE1046 10-46 Regular Light', 'Cable & String', 'Other', 460, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\D’Addario XSE1046 10-46 Regular Light, XS Nickel Coated Electric Guitar Strings 460.png'),
(142, 'D’Addario XT 10-47 Phosphor Bronze Light', 'Cable & String', 'Other', 660, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\D’Addario XT 10-47 Phosphor Bronze Light 12-String 660.png'),
(143, 'D’Addario XT 12-53 Phosphor Bronze Light', 'Cable & String', 'Other', 420, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\D’Addario XT 12-53 Phosphor Bronze Light 420.png'),
(144, 'Ernie Ball Mega Slinky Nickel Wound 10.5-48 ', 'Cable & String', 'Other', 180, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Ernie Ball Mega Slinky Nickel Wound 10.5-48 180.png'),
(145, 'Dimarzio Guitar Cable 18ft EP1618 ', 'Cable & String', 'Other', 950, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Dimarzio Guitar Cable 18ft EP1618 950.png'),
(146, 'Mogami Platinum Guitar Cable 20ft R ', 'Cable & String', 'Other', 4900, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Mogami Platinum Guitar Cable 20ft R 4900.png'),
(147, 'Ernie Ball FLAT RIBBON PATCH CABLE 12', 'Cable & String', 'Other', 790, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Ernie Ball FLAT RIBBON PATCH CABLE 12″ WHITE Pack 3 790.png'),
(148, 'Valeton PCA-10 Daisy', 'Cable & String', 'Other', 400, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Valeton PCA-10 Daisy Chain DC Power Cable 400.png'),
(149, 'Mono Pedalboard Lite+ ', 'Pedalboard', 'Other', 5500, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Mono Pedalboard Lite+ 5500.png'),
(150, 'Mono PRO2.0 ', 'Pedalboard', 'Other', 4410, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Mono PRO2.0 Soft Case + Pedalboard L 4410.png'),
(152, 'Pedaltrain Novo 24 Soft Case ', 'Pedalboard', 'Other', 4050, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Pedaltrain Novo 24 Soft Case 4050.png'),
(153, 'American Professional II ', 'Fender', 'Jazz Bass', 63000, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\American Professional II jazz  63,000.png'),
(154, 'Fender American Ultra ', 'Fender', 'Jazz Bass ', 76500, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender American Ultra Jazz Bass 76500.png'),
(155, 'Fender Player Plus', 'Fender', 'Jazz Bass ', 40500, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Player Plus Jazz Bass 40500.png'),
(156, 'Fender Vintera 60s ', 'Fender', 'Jazz Bass ', 40500, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Vintera 60s Jazz Bass 40500.png'),
(157, 'Fender American Performer ', 'Fender', 'Mustang Bass', 54000, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender American Performer Mustang Bass 54000.png'),
(158, 'Fender JMJ Road Worn ', 'Fender', 'Mustang Bass ', 43200, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender JMJ Road Worn Mustang Bass 43200.png'),
(159, 'Fender Player Mustang Bass PJ ', 'Fender', 'Mustang Bass', 28800, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Player Mustang Bass PJ 28800.png'),
(160, 'Fender American Ultra ', 'Fender', 'Precision Bass ', 73800, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender American Ultra Precision Bass 73800.png'),
(161, 'Fender American Professional II ', 'Fender', 'Precision Bass ', 61200, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender American Professional II Precision Bass 61200.png'),
(162, 'Fender Duff Mckagan Deluxe ', 'Fender', 'Precision Bass ', 45000, 9, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Duff Mckagan Deluxe Precision Bass 45000.png'),
(163, 'Fender Player Plus ', 'Fender', 'Precision Bass ', 39600, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Player Plus Precision Bass 39600.png'),
(164, 'Fender Tony Franklin Fretless ', 'Fender', 'Precision Bass ', 72000, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Tony Franklin Fretless Precision Bass 72000.png'),
(165, 'Fender Player Jaguar Bass ', 'Fender', 'Jaguar Bass ', 28800, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Player Jaguar Bass 28800.png'),
(167, 'Fender Hammertone Delay ', 'delay', 'Effect', 3960, 100, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Fender Hammertone Delay 3960.png'),
(168, 'Blackstar HT Club 40 MKII ', 'Blackstar', 'amp', 31500, 10, 'C:\\Users\\WINDOWS\\Desktop\\PROJECT C#\\PROJECT C#\\imageckp\\Blackstar HT Club 40 MKII 31500.png');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customerinfo`
--
ALTER TABLE `customerinfo`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `history`
--
ALTER TABLE `history`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `shopping_cart`
--
ALTER TABLE `shopping_cart`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customerinfo`
--
ALTER TABLE `customerinfo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=65;

--
-- AUTO_INCREMENT for table `history`
--
ALTER TABLE `history`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=668;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- AUTO_INCREMENT for table `shopping_cart`
--
ALTER TABLE `shopping_cart`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=815;

--
-- AUTO_INCREMENT for table `stock`
--
ALTER TABLE `stock`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=169;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
