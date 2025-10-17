CREATE TABLE `szobak`(
    `szobaazonosito` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `szobanev` LINESTRING NOT NULL,
    `agyszam` INT NOT NULL,
    `potagyszam` INT NOT NULL
);
CREATE TABLE `vendegek`(
    `vendegsorszam` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `vendegnev` LINESTRING NOT NULL,
    `telefnszam` BIGINT NOT NULL,
    `allapot` LINESTRING NOT NULL,
    `nemzetiseg` LINESTRING NOT NULL
);
CREATE TABLE `foglalasok`(
    `foglalasid` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `vendegid` INT NOT NULL,
    `szobaid` INT NOT NULL,
    `erkezes` DATE NOT NULL,
    `tavozas` DATE NOT NULL,
    `szallofo` INT NOT NULL
);
ALTER TABLE
    `foglalasok` ADD CONSTRAINT `foglalasok_szobaid_foreign` FOREIGN KEY(`szobaid`) REFERENCES `szobak`(`szobaazonosito`);
ALTER TABLE
    `foglalasok` ADD CONSTRAINT `foglalasok_vendegid_foreign` FOREIGN KEY(`vendegid`) REFERENCES `vendegek`(`vendegsorszam`);