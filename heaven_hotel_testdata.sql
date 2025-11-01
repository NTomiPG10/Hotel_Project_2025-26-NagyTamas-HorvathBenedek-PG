-- === TÁBLÁK LÉTREHOZÁSA ===
DROP TABLE IF EXISTS foglalasok;
DROP TABLE IF EXISTS vendegek;
DROP TABLE IF EXISTS szobak;

CREATE TABLE szobak (
    szobaazonosito INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    szobanev VARCHAR(50) NOT NULL,
    agyszam INT NOT NULL,
    potagyszam INT NOT NULL
);

CREATE TABLE vendegek (
    vendegsorszam INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    vendegnev VARCHAR(100) NOT NULL,
    telefonszam VARCHAR(20) NOT NULL,
    allapot VARCHAR(50) NOT NULL,
    nemzetiseg VARCHAR(50) NOT NULL
);

CREATE TABLE foglalasok (
    foglalasid INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    vendegid INT UNSIGNED NOT NULL,
    szobaid INT UNSIGNED NOT NULL,
    erkezes DATE NOT NULL,
    tavozas DATE NOT NULL,
    szallofo INT NOT NULL,
    FOREIGN KEY (vendegid) REFERENCES vendegek(vendegsorszam),
    FOREIGN KEY (szobaid) REFERENCES szobak(szobaazonosito)
);

-- === TESZTADATOK FELTÖLTÉSE ===

-- Szobák (10 db)
INSERT INTO szobak (szobanev, agyszam, potagyszam) VALUES
('101-es szoba', 2, 0),
('102-es szoba', 3, 1),
('103-as szoba', 1, 1),
('104-es szoba', 2, 0),
('201-es lakosztály', 4, 2),
('202-es szoba', 2, 0),
('203-as szoba', 3, 0),
('301-es szoba', 1, 1),
('302-es szoba', 2, 0),
('303-as szoba', 2, 1);

-- Vendégek (20 db)
INSERT INTO vendegek (vendegnev, telefonszam, allapot, nemzetiseg) VALUES
('Kiss Péter', '06201234567', 'Foglalt', 'Magyar'),
('Nagy Anna', '06301239876', 'Fizetett', 'Magyar'),
('Smith John', '00442011223344', 'Foglalt', 'Angol'),
('Müller Franz', '0049123456789', 'Lemondta', 'Német'),
('Takahashi Yui', '0081309876543', 'Fizetett', 'Japán'),
('Popescu Andrei', '0040123456789', 'Foglalt', 'Román'),
('Garcia Maria', '0034609876543', 'Foglalt', 'Spanyol'),
('Dupont Elise', '0033145678901', 'Fizetett', 'Francia'),
('Johnson Emily', '0012023456789', 'Foglalt', 'Amerikai'),
('Ivanov Sergey', '0079123456789', 'Foglalt', 'Orosz'),
('Novák László', '06202223344', 'Lemondta', 'Magyar'),
('Horváth Dóra', '06204445566', 'Fizetett', 'Magyar'),
('Sato Haru', '0081345678901', 'Foglalt', 'Japán'),
('Kim Jihoon', '0082209876543', 'Foglalt', 'Koreai'),
('Anderson Mark', '0013105556677', 'Fizetett', 'Amerikai'),
('Lopez Carlos', '0034602233445', 'Foglalt', 'Spanyol'),
('Liu Wei', '0086123456789', 'Foglalt', 'Kínai'),
('Kovács Dániel', '06305556677', 'Fizetett', 'Magyar'),
('Szabó Réka', '06306667788', 'Foglalt', 'Magyar'),
('Tóth Bence', '06207778899', 'Fizetett', 'Magyar');

-- Foglalások (20 db)
INSERT INTO foglalasok (vendegid, szobaid, erkezes, tavozas, szallofo) VALUES
(1, 1, '2025-11-05', '2025-11-08', 2),
(2, 2, '2025-11-10', '2025-11-13', 3),
(3, 3, '2025-12-01', '2025-12-05', 2),
(4, 4, '2025-10-15', '2025-10-18', 4),
(5, 5, '2025-11-20', '2025-11-23', 2),
(6, 6, '2025-11-25', '2025-11-27', 2),
(7, 7, '2025-12-03', '2025-12-07', 3),
(8, 8, '2025-12-15', '2025-12-19', 2),
(9, 9, '2025-11-18', '2025-11-21', 1),
(10, 10, '2025-12-22', '2025-12-26', 2),
(11, 1, '2025-11-28', '2025-12-01', 2),
(12, 2, '2025-12-02', '2025-12-05', 2),
(13, 3, '2025-11-12', '2025-11-15', 1),
(14, 4, '2025-11-09', '2025-11-11', 2),
(15, 5, '2025-12-10', '2025-12-14', 4),
(16, 6, '2025-12-20', '2025-12-23', 3),
(17, 7, '2025-11-01', '2025-11-03', 2),
(18, 8, '2025-11-14', '2025-11-17', 1),
(19, 9, '2025-11-30', '2025-12-02', 2),
(20, 10, '2025-12-27', '2025-12-31', 3);
