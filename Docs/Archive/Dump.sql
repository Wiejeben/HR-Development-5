CREATE TABLE `countries` (
 `id` INT NOT NULL,
 `name` VARCHAR(255) NOT NULL
);

ALTER TABLE `countries` ADD CONSTRAINT `PK_countries` PRIMARY KEY (`id`);


CREATE TABLE `courses` (
 `id` INT NOT NULL,
 `name` VARCHAR(255) NOT NULL
);

ALTER TABLE `courses` ADD CONSTRAINT `PK_courses` PRIMARY KEY (`id`);


CREATE TABLE `levels` (
 `id` INT NOT NULL,
 `name` VARCHAR(255) NOT NULL
);

ALTER TABLE `levels` ADD CONSTRAINT `PK_levels` PRIMARY KEY (`id`);


CREATE TABLE `positions` (
 `id` INT NOT NULL,
 `name` VARCHAR(255) NOT NULL,
 `description` VARCHAR(255) NOT NULL,
 `hour_fee` FLOAT(10) NOT NULL
);

ALTER TABLE `positions` ADD CONSTRAINT `PK_positions` PRIMARY KEY (`id`);


CREATE TABLE `provinces` (
 `id` INT NOT NULL,
 `city_id` INT NOT NULL,
 `name` VARCHAR(255) NOT NULL
);

ALTER TABLE `provinces` ADD CONSTRAINT `PK_provinces` PRIMARY KEY (`id`);


CREATE TABLE `schools` (
 `id` INT NOT NULL,
 `name` VARCHAR(255) NOT NULL
);

ALTER TABLE `schools` ADD CONSTRAINT `PK_schools` PRIMARY KEY (`id`);


CREATE TABLE `cities` (
 `id` INT NOT NULL,
 `province_id` INT NOT NULL,
 `name` VARCHAR(255) NOT NULL
);

ALTER TABLE `cities` ADD CONSTRAINT `PK_cities` PRIMARY KEY (`id`);


CREATE TABLE `degrees` (
 `id` INT NOT NULL,
 `school_id` INT NOT NULL,
 `level_id` INT NOT NULL,
 `course_id` INT NOT NULL
);

ALTER TABLE `degrees` ADD CONSTRAINT `PK_degrees` PRIMARY KEY (`id`);


CREATE TABLE `streets` (
 `id` INT NOT NULL,
 `city_id` INT NOT NULL,
 `name` VARCHAR(255) NOT NULL
);

ALTER TABLE `streets` ADD CONSTRAINT `PK_streets` PRIMARY KEY (`id`);


CREATE TABLE `addresses` (
 `id` INT NOT NULL,
 `street_id` INT NOT NULL,
 `number` INT NOT NULL,
 `addition` CHAR(5),
 `postal_code` VARCHAR(30)
);

ALTER TABLE `addresses` ADD CONSTRAINT `PK_addresses` PRIMARY KEY (`id`);


CREATE TABLE `headquarters` (
 `name` VARCHAR(255) NOT NULL,
 `number_of_rooms` INT,
 monthly_rent FLOAT(10),
 `address_id` INT NOT NULL
);

ALTER TABLE `headquarters` ADD CONSTRAINT `PK_headquarters` PRIMARY KEY (`name`);


CREATE TABLE `projects` (
 `id` INT NOT NULL,
 `budget` FLOAT(10),
 `allocated_hours` INT,
 `headquarter_name` VARCHAR(255)
);

ALTER TABLE `projects` ADD CONSTRAINT `PK_projects` PRIMARY KEY (`id`);


CREATE TABLE `employees` (
 `bsn` INT NOT NULL,
 `name` VARCHAR(255) NOT NULL,
 `surname` VARCHAR(255) NOT NULL,
 `headquarter_name` VARCHAR(255)
);

ALTER TABLE `employees` ADD CONSTRAINT `PK_employees` PRIMARY KEY (`bsn`);


CREATE TABLE `position_project` (
 `project_id` INT NOT NULL,
 `position_id` INT NOT NULL
);

ALTER TABLE `position_project` ADD CONSTRAINT `PK_position_project` PRIMARY KEY (`project_id`,`position_id`);


CREATE TABLE `address_employee` (
 `bsn` INT NOT NULL,
 `address_id` INT NOT NULL,
 `residence` tinyint(1) DEFAULT 0 NOT NULL
);

ALTER TABLE `address_employee` ADD CONSTRAINT `PK_address_employee` PRIMARY KEY (`bsn`,`address_id`);


CREATE TABLE `employee_degree` (
 `employee_bsn` INT NOT NULL,
 `degree_id` INT NOT NULL
);

ALTER TABLE `employee_degree` ADD CONSTRAINT `PK_employee_degree` PRIMARY KEY (`employee_bsn`,`degree_id`);


CREATE TABLE `employee_position` (
 `bsn` INT NOT NULL,
 `position_id` INT NOT NULL
);

ALTER TABLE `employee_position` ADD CONSTRAINT `PK_employee_position` PRIMARY KEY (`bsn`,`position_id`);


ALTER TABLE `provinces` ADD CONSTRAINT `FK_provinces_0` FOREIGN KEY (`city_id`) REFERENCES `countries` (`id`);


ALTER TABLE `cities` ADD CONSTRAINT `FK_cities_0` FOREIGN KEY (`province_id`) REFERENCES `provinces` (`id`);


ALTER TABLE `degrees` ADD CONSTRAINT `FK_degrees_0` FOREIGN KEY (`school_id`) REFERENCES `schools` (`id`);
ALTER TABLE `degrees` ADD CONSTRAINT `FK_degrees_1` FOREIGN KEY (`level_id`) REFERENCES `levels` (`id`);
ALTER TABLE `degrees` ADD CONSTRAINT `FK_degrees_2` FOREIGN KEY (`course_id`) REFERENCES `courses` (`id`);


ALTER TABLE `streets` ADD CONSTRAINT `FK_streets_0` FOREIGN KEY (`city_id`) REFERENCES `cities` (`id`);


ALTER TABLE `addresses` ADD CONSTRAINT `FK_addresses_0` FOREIGN KEY (`street_id`) REFERENCES `streets` (`id`);


ALTER TABLE `headquarters` ADD CONSTRAINT `FK_headquarters_0` FOREIGN KEY (`address_id`) REFERENCES `addresses` (`id`);


ALTER TABLE `projects` ADD CONSTRAINT `FK_projects_0` FOREIGN KEY (`headquarter_name`) REFERENCES `headquarters` (`name`);


ALTER TABLE `employees` ADD CONSTRAINT `FK_employees_0` FOREIGN KEY (`headquarter_name`) REFERENCES `headquarters` (`name`);


ALTER TABLE `position_project` ADD CONSTRAINT `FK_position_project_0` FOREIGN KEY (`project_id`) REFERENCES `projects` (`id`);
ALTER TABLE `position_project` ADD CONSTRAINT `FK_position_project_1` FOREIGN KEY (`position_id`) REFERENCES `positions` (`id`);


ALTER TABLE `address_employee` ADD CONSTRAINT `FK_address_employee_0` FOREIGN KEY (`bsn`) REFERENCES `employees` (`bsn`);
ALTER TABLE `address_employee` ADD CONSTRAINT `FK_address_employee_1` FOREIGN KEY (`address_id`) REFERENCES `addresses` (`id`);


ALTER TABLE `employee_degree` ADD CONSTRAINT `FK_employee_degree_0` FOREIGN KEY (`employee_bsn`) REFERENCES `employees` (`bsn`);
ALTER TABLE `employee_degree` ADD CONSTRAINT `FK_employee_degree_1` FOREIGN KEY (`degree_id`) REFERENCES `degrees` (`id`);


ALTER TABLE `employee_position` ADD CONSTRAINT `FK_employee_position_0` FOREIGN KEY (`bsn`) REFERENCES `employees` (`bsn`);
ALTER TABLE `employee_position` ADD CONSTRAINT `FK_employee_position_1` FOREIGN KEY (`position_id`) REFERENCES `positions` (`id`);


