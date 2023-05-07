
create database gameshowhanngu;
use gameshowhanngu;
-- bảng bộ đề
create table question_topic(
	id_topic int IDENTITY(1,1),
	name_topic nvarchar(30),
	primary key(id_topic)
);
insert into question_topic(name_topic) values ('Bộ Đề 1')
insert into question_topic(name_topic) values ('Bộ Đề 2')
insert into question_topic(name_topic) values ('Bộ Đề 3')
insert into question_topic(name_topic) values ('Bộ Đề 4')
insert into question_topic(name_topic) values ('Bộ Đề 5')
insert into question_topic(name_topic) values ('Bộ Đề 6')

-- bảng trạng thái led
create table status_led
(
	id int IDENTITY(1,1),
	count_status int,
	primary key (id)
);

-- bảng status chuyển câu
create table status_next_question
(
	id int IDENTITY(1,1),
	count_status_next_question int,
	primary key (id)
);
insert into status_next_question(count_status_next_question) values (0);

create table status_team
(
	id int IDENTITY(1,1),
	count_team int,
	primary key(id)
);
insert into status_team(count_team) values (0);


insert into status_led(count_status) values (0);

--Bảng Loại Câu Hỏi
create table question_type
(
	id int IDENTITY(1,1), 
	type_of_name nvarchar(20),
	primary key(id),

);

insert into question_type (type_of_name) values ('true question')
insert into question_type (type_of_name) values ('matching question')

--Bảng Trạng Thái
create table statuss(
	id_status int IDENTITY(1,1),
	name_status nvarchar(30),
	primary key (id_status)
);
insert into statuss (name_status) values ('Chưa Thi')
insert into statuss (name_status) values ('Đang Thi')
insert into statuss (name_status) values ('Đã Thi')
select * from statuss
-- bảng câu hỏi
create table questions(
	id_question int IDENTITY(1,1),
	true_answer nvarchar(10),
	point int,
	name_question nvarchar(10),
	img_question image,
	id_status int,
	id_topic int,
	id_question_type int,
	primary key(id_question),
	FOREIGN KEY (id_topic) REFERENCES question_topic(id_topic),
	FOREIGN KEY (id_status) REFERENCES statuss(id_status),
	FOREIGN KEY (id_question_type) REFERENCES question_type(id)
);

INSERT INTO questions(true_answer, point, name_question, id_status, id_topic ,id_question_type, img_question)
values('A', 1, 'Câu 1', 1, 1, 1, (select * from openrowset(Bulk 'D:\C#\minigame\Image\FileHinhDe.png', SINGLE_BLOB)as img_question))
INSERT INTO questions(true_answer, point, name_question, id_status, id_topic ,id_question_type, img_question)
values('B', 1, 'Câu 2', 1, 1, 1, (select * from openrowset(Bulk 'D:\C#\minigame\Image\FileHinhDe.png', SINGLE_BLOB)as img_question))
INSERT INTO questions(true_answer, point, name_question, id_status, id_topic ,id_question_type, img_question)
values('B', 1, 'Câu 3', 1, 1, 1, (select * from openrowset(Bulk 'D:\C#\minigame\Image\FileHinhDe.png', SINGLE_BLOB)as img_question))


INSERT INTO questions(true_answer, point, name_question, id_status, id_topic ,id_question_type, img_question)
values('A', 1, 'Câu 4', 1, 2, 1, (select * from openrowset(Bulk 'D:\C#\minigame\Image\FileHinhDe.png', SINGLE_BLOB)as img_question))
INSERT INTO questions(true_answer, point, name_question, id_status, id_topic ,id_question_type, img_question)
values('B', 1, 'Câu 5', 1, 2, 1, (select * from openrowset(Bulk 'D:\C#\minigame\Image\FileHinhDe.png', SINGLE_BLOB)as img_question))
INSERT INTO questions(true_answer, point, name_question, id_status, id_topic ,id_question_type, img_question)
values('B', 1, 'Câu 6', 1, 2, 1, (select * from openrowset(Bulk 'D:\C#\minigame\Image\FileHinhDe.png', SINGLE_BLOB)as img_question))

INSERT INTO questions(true_answer, point, name_question, id_status, id_topic ,id_question_type, img_question)
values('D', 1, 'Câu 7', 1, 3, 1, (select * from openrowset(Bulk 'D:\C#\minigame\Image\FileHinhDe.png', SINGLE_BLOB)as img_question))
INSERT INTO questions(true_answer, point, name_question, id_status, id_topic ,id_question_type, img_question)
values('B', 1, 'Câu 8', 1, 3, 1, (select * from openrowset(Bulk 'D:\C#\minigame\Image\FileHinhDe.png', SINGLE_BLOB)as img_question))
INSERT INTO questions(true_answer, point, name_question, id_status, id_topic ,id_question_type, img_question)
values('C', 1, 'Câu 9', 1, 3, 1, (select * from openrowset(Bulk 'D:\C#\minigame\Image\FileHinhDe.png', SINGLE_BLOB)as img_question))
select * from questions

create table team_battle(
	id_team int IDENTITY(1,1),
	name_team nvarchar(30),
	id_topic int,
	primary key (id_team),
	foreign key (id_topic) references question_topic(id_topic)
);

insert into team_battle(name_team, id_topic) values ('Đội 1', 1)
insert into team_battle(name_team, id_topic) values ('Đội 2', 2)
insert into team_battle(name_team, id_topic) values ('Đội 3', 3)
select * from team_battle

-- bảng học sinh
create table student(
	id_student int IDENTITY(1,1),
	name_account nvarchar(100),
	pass varchar(100),
	fullname nvarchar(100),
	point int,
	id_team int,
	primary key(id_student),
	FOREIGN KEY (id_team) REFERENCES team_battle(id_team),
);

insert into student(name_account, pass, fullname, point, id_team) values ('hai123', '123', 'Nguyễn Minh Hải', 0, 1)
insert into student(name_account, pass, fullname, point, id_team) values ('a123', '123', 'Nguyễn Văn A', 0, 1)

insert into student(name_account, pass, fullname, point, id_team) values ('b123', '123', 'Nguyễn Văn B', 0, 1)
insert into student(name_account, pass, fullname, point, id_team) values ('c123', '123', 'Nguyễn Văn C', 0, 1)

insert into student(name_account, pass, fullname, point, id_team) values ('d123', '123', 'Nguyễn Văn D', 0, 1)
insert into student(name_account, pass, fullname, point, id_team) values ('e123', '123', 'Nguyễn Văn E', 0, 1)
insert into student(name_account, pass, fullname, point, id_team) values ('e123', '123', N'Nguyễn Văn E', 0, 1)
select * from student
-- bảng đáp án của sinh viên
create table answers_of_student(
	id_answer_of_student int IDENTITY(1,1),
	id_student int,
	id_question int,
	time_of_answer int,
	answers nvarchar(30),
	primary key(id_answer_of_student),
	FOREIGN KEY (id_student) REFERENCES student(id_student),
	FOREIGN KEY (id_question) REFERENCES questions(id_question)
);

insert into answers_of_student(id_student, id_question, time_of_answer, answers) values (1, 1, 0, 'A')
insert into answers_of_student(id_student, id_question, time_of_answer, answers) values (2, 1, 0, 'A')
insert into answers_of_student(id_student, id_question, time_of_answer, answers) values (3, 1, 0, 'A')
insert into answers_of_student(id_student, id_question, time_of_answer, answers) values (4, 1, 0, 'A')
insert into answers_of_student(id_student, id_question, time_of_answer, answers) values (5, 1, 0, 'A')
insert into answers_of_student(id_student, id_question, time_of_answer, answers) values (6, 1, 0, 'A')
insert into answers_of_student(id_student, id_question, time_of_answer, answers) values (6, 1, 0, 'A')


select* from answers_of_student



