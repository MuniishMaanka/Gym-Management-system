https://www.sqlite.org/lang_datefunc.html
https://www.c-sharpcorner.com/article/null-values-in-sql/

-- Staffs
Insert into staff_information Values('0', 'Mohamed', ' ', date('2000-04-02'), '123455', 'a@gmail.com', 'male', 'Xamar', 'Mog', 'asdf','asdf','asdf','day','Admin',200.0)

-- Users
INSERT into users(staff_id, username, password) VALUES(0, 'Mohamed','000')

-- Add New Plan 
INSERT INTO plans (plan_name, signup_fee, price, staff_id, plan_type) VALUES ('NightWork', 20.0, 10.0, '5', 'Oneday');
INSERT INTO Schedule ( plan_id, time_in, time_out) VALUES ((SELECT DISTINCT last_insert_rowid() as id from plans), time('01:00'), time('03:00'));




CREATE TABLE "revenue" (
	"id"	VARCHAR(255),
	"customer_id"	VARCHAR(255),
	"amount"	FLOAT,
	"date_issue"	DATETIME,
	"user_id"	VARCHAR(255),
	PRIMARY KEY("id"),
	FOREIGN KEY("user_id") REFERENCES "users"("id"),
	FOREIGN KEY("customer_id") REFERENCES "customer_information"("id")
);

CREATE TABLE "plans" (
	"id"	INTEGER,
	"plan_name"	VARCHAR(20) NOT NULL UNIQUE,
	"signup_fee"	FLOAT NOT NULL,
	"price"	FLOAT NOT NULL,
	"staff_id"	VARCHAR(255),
	"plan_type"	VARCHAR(20),
	PRIMARY KEY("id" AUTOINCREMENT),
	FOREIGN KEY("staff_id") REFERENCES "staff_information"("id") ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE "users" (
	"id"	INTEGER,
	"staff_id"	INTEGER,
	"username"	VARCHAR(30),
	"password"	VARCHAR(30),
	FOREIGN KEY("staff_id") REFERENCES "staff_information"("id"),
	PRIMARY KEY("id")
);

CREATE TABLE "schedule" (
	"id"	INTEGER,
	"plan_id"	INTEGER,
	"time_in"	TIMESTAMP,
	"time_out"	TIMESTAMP,
	PRIMARY KEY("id" AUTOINCREMENT),
	FOREIGN KEY("plan_id") REFERENCES "plans"("id") On Delete Cascade
);

CREATE TABLE "salaries" (
	"id"	INTEGER,
	"staff_id"	INTEGER,
	"amount"	FLOAT,
	"date"	DATETIME,
	FOREIGN KEY("staff_id") REFERENCES "staff_information"("id"),
	PRIMARY KEY("id")
);


CREATE TABLE customer_information (
    id VARCHAR(255) PRIMARY KEY,
    firstname VARCHAR(255),
    lastname VARCHAR(255),
    dob TIMESTAMP,
    tell VARCHAR(255),
    email VARCHAR(255),
    sex VARCHAR(255),
    weight FLOAT,
    city VARCHAR(255),
    village VARCHAR(255),
    emmergence_contact VARCHAR(255),
    emmergency_name VARCHAR(255),
    emergency_relation VARCHAR(255)
);

CREATE TABLE plans (
    id VARCHAR(255) PRIMARY KEY,
    plan_name VARCHAR(255),
    signup_fee FLOAT,
    price FLOAT,
    staff_id VARCHAR(255),
    customer_id VARCHAR(255),
    plan_type VARCHAR(255),
    FOREIGN KEY (staff_id) REFERENCES staff_information(id),
    FOREIGN KEY (customer_id) REFERENCES customer_information(id)
);

CREATE TABLE measurement (
    id VARCHAR(255) PRIMARY KEY,
    customer_id VARCHAR(255),
    weight FLOAT,
    date_issue TIMESTAMP,
    description VARCHAR(255),
    FOREIGN KEY (customer_id) REFERENCES customer_information(id)
);

CREATE TABLE schedule (
    id VARCHAR(255) PRIMARY KEY,
    plan_id VARCHAR(255),
    customer_id VARCHAR(255),
    time_in TIMESTAMP,
    time_out TIMESTAMP,
    FOREIGN KEY (plan_id) REFERENCES plans(id),
    FOREIGN KEY (customer_id) REFERENCES customer_information(id)
);

CREATE TABLE staff_information (
    id VARCHAR(255) PRIMARY KEY,
    firstname VARCHAR(255),
    lastname VARCHAR(255),
    dob TIMESTAMP,
    tell VARCHAR(255),
    email VARCHAR(255),
    sex VARCHAR(255),
    city VARCHAR(255),
    village VARCHAR(255),
    emmergence_contact VARCHAR(255),
    emmergency_name VARCHAR(255),
    emergency_relation VARCHAR(255),
    shift VARCHAR(255),
    staff_type VARCHAR(255),
    salary FLOAT
);

CREATE TABLE users (
    id VARCHAR(255) PRIMARY KEY,
    staff_id VARCHAR(255),
    username VARCHAR(255),
    password VARCHAR(255),
    user_type VARCHAR(255),
    FOREIGN KEY (staff_id) REFERENCES staff_information(id)
);

CREATE TABLE salaries (
    id VARCHAR(255) PRIMARY KEY,
    staff_id VARCHAR(255),
    amount FLOAT,
    date TIMESTAMP,
    FOREIGN KEY (staff_id) REFERENCES staff_information(id)
);

CREATE TABLE revenue (
    id VARCHAR(255) PRIMARY KEY,
    customer_id VARCHAR(255),
    amount FLOAT,
    date_issue TIMESTAMP,
    user_id VARCHAR(255),
    FOREIGN KEY (customer_id) REFERENCES customer_information(id),
    FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE attendance (
    id VARCHAR(255) PRIMARY KEY,
    sche_id VARCHAR(255),
    date TIMESTAMP,
    attendance_type VARCHAR(255),
    FOREIGN KEY (sche_id) REFERENCES schedule(id)
);