CREATE DATABASE `admitere` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

CREATE TABLE `answer` (
  `answer_id` int NOT NULL AUTO_INCREMENT,
  `answer` varchar(45) NOT NULL,
  PRIMARY KEY (`answer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `doc` (
  `doc_id` int NOT NULL AUTO_INCREMENT,
  `CI/BI` varchar(45) NOT NULL,
  `medical` varchar(45) NOT NULL,
  `photo` varchar(45) NOT NULL,
  `tax` varchar(45) NOT NULL,
  `diploma` varchar(45) NOT NULL,
  `app_form` varchar(45) NOT NULL,
  PRIMARY KEY (`doc_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `exam` (
  `exam_id` int NOT NULL AUTO_INCREMENT,
  `exam_name` varchar(45) NOT NULL,
  `exam_grade` varchar(45) NOT NULL,
  PRIMARY KEY (`exam_id`),
  CONSTRAINT `faculty_id` FOREIGN KEY (`exam_id`) REFERENCES `faculty` (`faculty_id`),
  CONSTRAINT `question_id` FOREIGN KEY (`exam_id`) REFERENCES `question` (`question_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `faculty` (
  `faculty_id` int NOT NULL AUTO_INCREMENT,
  `faculty_name` varchar(45) NOT NULL,
  `department` varchar(45) NOT NULL,
  PRIMARY KEY (`faculty_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `question` (
  `question_id` int NOT NULL AUTO_INCREMENT,
  `question` varchar(45) NOT NULL,
  PRIMARY KEY (`question_id`),
  CONSTRAINT `answer_id` FOREIGN KEY (`question_id`) REFERENCES `answer` (`answer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `role` (
  `role_id` int NOT NULL AUTO_INCREMENT,
  `admin` varchar(45) NOT NULL,
  `end_user` varchar(45) NOT NULL,
  PRIMARY KEY (`role_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `user` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `CNP` int NOT NULL,
  `e-mail` varchar(45) NOT NULL,
  `phone` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username_UNIQUE` (`username`),
  CONSTRAINT `doc_id` FOREIGN KEY (`user_id`) REFERENCES `doc` (`doc_id`),
  CONSTRAINT `exam_id` FOREIGN KEY (`user_id`) REFERENCES `exam` (`exam_id`),
  CONSTRAINT `user_id` FOREIGN KEY (`user_id`) REFERENCES `role` (`role_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
