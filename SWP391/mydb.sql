-- MySQL Script generated by MySQL Workbench
-- Tue Jan 30 23:00:17 2024
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8mb3 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`postcategories`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`postcategories` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `status` INT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`settings`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`settings` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NULL DEFAULT NULL,
  `value` VARCHAR(255) CHARACTER SET 'utf8mb3' NOT NULL,
  `type` VARCHAR(50) CHARACTER SET 'utf8mb3' NOT NULL,
  `order` INT NOT NULL,
  `description` TEXT NULL DEFAULT NULL,
  `isActive` BIT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`user`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`user` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `email` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `full_name` VARCHAR(45) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `phone` VARCHAR(45) NULL DEFAULT NULL,
  `gender` VARCHAR(45) NULL DEFAULT NULL,
  `registration_date` DATE NULL DEFAULT NULL,
  `status` INT NULL DEFAULT NULL,
  `updatedBy` INT NULL DEFAULT NULL,
  `updatedDate` DATE NULL DEFAULT NULL,
  `image` VARCHAR(255) NULL DEFAULT NULL,
  `settings_id` INT NOT NULL,
  PRIMARY KEY (`id`, `settings_id`),
  UNIQUE INDEX `username_UNIQUE` (`email` ASC) VISIBLE,
  INDEX `fk_user_settings1_idx` (`settings_id` ASC) VISIBLE,
  CONSTRAINT `fk_user_settings1`
    FOREIGN KEY (`settings_id`)
    REFERENCES `mydb`.`settings` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`blogs_posts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`blogs_posts` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(255) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `brief_info` TEXT NULL DEFAULT NULL,
  `thumbnail` VARCHAR(200) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `details` TEXT NULL DEFAULT NULL,
  `updatedDate` DATETIME NULL DEFAULT NULL,
  `PostCategories_id` INT NOT NULL,
  `User_id` INT NOT NULL,
  `flag_feature` INT NULL DEFAULT NULL,
  `status` INT NULL DEFAULT NULL,
  `blogs_postscol` VARCHAR(45) NULL,
  PRIMARY KEY (`id`, `PostCategories_id`, `User_id`),
  INDEX `fk_Blogs_PostCategories1_idx` (`PostCategories_id` ASC) VISIBLE,
  INDEX `fk_Blogs_User1_idx` (`User_id` ASC) VISIBLE,
  CONSTRAINT `fk_Blogs_PostCategories1`
    FOREIGN KEY (`PostCategories_id`)
    REFERENCES `mydb`.`postcategories` (`id`),
  CONSTRAINT `fk_Blogs_User1`
    FOREIGN KEY (`User_id`)
    REFERENCES `mydb`.`user` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`productcategory`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`productcategory` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `categoryName` VARCHAR(100) CHARACTER SET 'utf8mb3' NOT NULL,
  `status` INT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`Brand`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Brand` (
  `brandID` INT NOT NULL AUTO_INCREMENT,
  `brandName` VARCHAR(100) NULL,
  `status` INT NULL,
  PRIMARY KEY (`brandID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`product`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`product` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) CHARACTER SET 'utf8mb3' NOT NULL,
  `originalPrice` DOUBLE NOT NULL,
  `salePrice` DOUBLE NULL DEFAULT NULL,
  `details` TEXT NOT NULL,
  `image` VARCHAR(45) CHARACTER SET 'utf8mb3' NOT NULL,
  `stock` INT NULL DEFAULT NULL,
  `ProductCategory_ID` INT NOT NULL,
  `updatedDate` DATETIME NULL DEFAULT NULL,
  `status` INT NULL DEFAULT NULL,
  `cost_price` DOUBLE NULL DEFAULT NULL,
  `settings_id` INT NOT NULL,
  `brandID` INT NOT NULL,
  PRIMARY KEY (`ID`, `ProductCategory_ID`, `settings_id`, `brandID`),
  INDEX `fk_Product_ProductCategory1_idx` (`ProductCategory_ID` ASC) VISIBLE,
  INDEX `fk_product_settings1_idx` (`settings_id` ASC) VISIBLE,
  INDEX `fk_product_Brand1_idx` (`brandID` ASC) VISIBLE,
  CONSTRAINT `fk_Product_ProductCategory1`
    FOREIGN KEY (`ProductCategory_ID`)
    REFERENCES `mydb`.`productcategory` (`ID`),
  CONSTRAINT `fk_product_settings1`
    FOREIGN KEY (`settings_id`)
    REFERENCES `mydb`.`settings` (`id`),
  CONSTRAINT `fk_product_Brand1`
    FOREIGN KEY (`brandID`)
    REFERENCES `mydb`.`Brand` (`brandID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`detailimages`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`detailimages` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `image` VARCHAR(255) NULL DEFAULT NULL,
  `Product_ID` INT NOT NULL,
  PRIMARY KEY (`id`, `Product_ID`),
  INDEX `fk_DetailImages_Product1_idx` (`Product_ID` ASC) VISIBLE,
  CONSTRAINT `fk_DetailImages_Product1`
    FOREIGN KEY (`Product_ID`)
    REFERENCES `mydb`.`product` (`ID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`generalfeedback`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`generalfeedback` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `full-name` VARCHAR(100) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `gender` VARCHAR(45) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `email` VARCHAR(100) NULL DEFAULT NULL,
  `phone` VARCHAR(15) NULL DEFAULT NULL,
  `rating` INT NULL DEFAULT NULL,
  `image` VARCHAR(255) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `comment` TEXT NULL DEFAULT NULL,
  `User_id` INT NOT NULL,
  `status` INT NULL DEFAULT NULL,
  `image_status` VARCHAR(50) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  PRIMARY KEY (`id`, `User_id`),
  INDEX `fk_ProductFeedback_User1_idx` (`User_id` ASC) VISIBLE,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE,
  CONSTRAINT `fk_ProductFeedback_User10`
    FOREIGN KEY (`User_id`)
    REFERENCES `mydb`.`user` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`orders`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`orders` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `User_id` INT NOT NULL,
  `order_date` DATE NOT NULL,
  `total` DOUBLE NOT NULL,
  `status` INT NOT NULL,
  `discount` DOUBLE NULL DEFAULT NULL,
  `address` VARCHAR(45) CHARACTER SET 'utf8mb3' NOT NULL,
  `phone` VARCHAR(45) NOT NULL,
  `email` VARCHAR(100) NULL DEFAULT NULL,
  `notes` TEXT NULL DEFAULT NULL,
  `gender` VARCHAR(45) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `saleID` INT NULL DEFAULT NULL,
  `settings_id` INT NOT NULL,
  PRIMARY KEY (`ID`, `User_id`, `settings_id`),
  INDEX `fk_Orders_User1_idx` (`User_id` ASC) VISIBLE,
  INDEX `fk_orders_settings1_idx` (`settings_id` ASC) VISIBLE,
  CONSTRAINT `fk_orders_settings1`
    FOREIGN KEY (`settings_id`)
    REFERENCES `mydb`.`settings` (`id`),
  CONSTRAINT `fk_Orders_User1`
    FOREIGN KEY (`User_id`)
    REFERENCES `mydb`.`user` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`orderdetails`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`orderdetails` (
  `Product_ID` INT NOT NULL,
  `Orders_ID` INT NOT NULL,
  `price` DOUBLE NULL DEFAULT NULL,
  `quantity` INT NULL DEFAULT NULL,
  PRIMARY KEY (`Product_ID`, `Orders_ID`),
  INDEX `fk_OrderDetails_Orders1_idx` (`Orders_ID` ASC) VISIBLE,
  CONSTRAINT `fk_OrderDetails_Orders1`
    FOREIGN KEY (`Orders_ID`)
    REFERENCES `mydb`.`orders` (`ID`),
  CONSTRAINT `fk_OrderDetails_Product1`
    FOREIGN KEY (`Product_ID`)
    REFERENCES `mydb`.`product` (`ID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`productfeedback`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`productfeedback` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `full-name` VARCHAR(100) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `gender` VARCHAR(45) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `email` VARCHAR(100) NULL DEFAULT NULL,
  `phone` VARCHAR(15) NULL DEFAULT NULL,
  `rating` INT NULL DEFAULT NULL,
  `image` VARCHAR(255) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `comment` TEXT NULL DEFAULT NULL,
  `Product_ID` INT NOT NULL,
  `User_id` INT NOT NULL,
  `status` INT NULL DEFAULT NULL,
  `image_status` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id`, `Product_ID`, `User_id`),
  INDEX `fk_ProductFeedback_Product1_idx` (`Product_ID` ASC) VISIBLE,
  INDEX `fk_ProductFeedback_User1_idx` (`User_id` ASC) VISIBLE,
  CONSTRAINT `fk_ProductFeedback_Product1`
    FOREIGN KEY (`Product_ID`)
    REFERENCES `mydb`.`product` (`ID`),
  CONSTRAINT `fk_ProductFeedback_User1`
    FOREIGN KEY (`User_id`)
    REFERENCES `mydb`.`user` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`role`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`role` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `role_name` VARCHAR(45) CHARACTER SET 'utf8mb3' NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`slider`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`slider` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(100) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `image` VARCHAR(255) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `backlink` VARCHAR(255) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `status` INT NULL DEFAULT NULL,
  `notes` TEXT NULL DEFAULT NULL,
  `marketing_id` INT NOT NULL,
  `updated_date` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`id`, `marketing_id`),
  INDEX `fk_Slider_User1_idx` (`marketing_id` ASC) VISIBLE,
  CONSTRAINT `fk_Slider_User1`
    FOREIGN KEY (`marketing_id`)
    REFERENCES `mydb`.`user` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`user_role`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`user_role` (
  `User_id` INT NOT NULL,
  `Role_id` INT NOT NULL,
  PRIMARY KEY (`User_id`, `Role_id`),
  INDEX `fk_User_has_Role_Role1_idx` (`Role_id` ASC) VISIBLE,
  INDEX `fk_User_has_Role_User1_idx` (`User_id` ASC) VISIBLE,
  CONSTRAINT `fk_User_has_Role_Role1`
    FOREIGN KEY (`Role_id`)
    REFERENCES `mydb`.`role` (`id`),
  CONSTRAINT `fk_User_has_Role_User1`
    FOREIGN KEY (`User_id`)
    REFERENCES `mydb`.`user` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`useraddress`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`useraddress` (
  `user_address` VARCHAR(255) NULL DEFAULT NULL,
  `user_id` INT NOT NULL,
  PRIMARY KEY (`user_id`),
  INDEX `fk_table1_user1_idx` (`user_id` ASC) VISIBLE,
  CONSTRAINT `fk_table1_user1`
    FOREIGN KEY (`user_id`)
    REFERENCES `mydb`.`user` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;




-- -----------------------------------------------------
-- Table `mydb`.`CartItem`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`cartitem` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `status` INT NULL DEFAULT NULL,
  `total` DOUBLE NULL DEFAULT NULL,
  `user_id` INT NOT NULL,
  `quantity` INT NULL,
  `price` DOUBLE NULL,
  `product_ID` INT NOT NULL,
  PRIMARY KEY (`id`, `user_id`, `product_ID`),
  INDEX `fk_Cart_user1_idx` (`user_id` ASC) VISIBLE,
  INDEX `fk_cart_product1_idx` (`product_ID` ASC) VISIBLE,
  CONSTRAINT `fk_Cart_user1`
    FOREIGN KEY (`user_id`)
    REFERENCES `mydb`.`user` (`id`),
  CONSTRAINT `fk_cart_product1`
    FOREIGN KEY (`product_ID`)
    REFERENCES `mydb`.`product` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
