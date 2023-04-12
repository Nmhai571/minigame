create database gameshowhanngu;
use gameshowhanngu;

-- bảng bộ đề
create table question_topic(
	id_topic int,
	name_topic nvarchar(30),
	primary key(id_topic)
);


-- bảng câu hỏi
create table questions(
	id_question int,
	name_question nvarchar(255),
	description_name nvarchar(255),
	point int,
	id_topic int,
	primary key(id_question),
	FOREIGN KEY (id_topic) REFERENCES question_topic(id_topic)
);

-- bảng các đội
create table team(
	id_team int,
	name_team nvarchar(30),
	primary key (id_team)
);

-- bảng đáp án
create table true_answers(
	id_answer int,
	name_answers nvarchar(255),
	id_question int,
	primary key(id_answer),
	FOREIGN KEY (id_question) REFERENCES questions(id_question)
);

-- bảng điểm của sinh viên sau khi trả lời xong 10 câu
create table point_of_student(
	id_point int,
	point int,
	primary key(id_point)
);
-- bảng học sinh
create table student(
	id_student int,
	name_account nvarchar(100),
	pass varchar(100),
	fullname nvarchar(100),
	team_id int,
	id_point_student int,
	answer_student_id int,
	primary key(id_student),
	FOREIGN KEY (team_id) REFERENCES team(id_team),
	FOREIGN KEY (id_point_student) REFERENCES point_of_student(id_point)
	
);

-- bảng đáp án của sinh viên
create table answers_of_student(
	id_answer_student int,
	id_student int,
	id_true_answer int,
	primary key(id_answer_student),
	FOREIGN KEY (id_student) REFERENCES student(id_student),
	FOREIGN KEY (id_true_answer) REFERENCES true_answers(id_answer)

);






-- bảng thời gian
create table times(
	id_time int,
	num_os_time int,
	primary key(id_time)
);

-- bảng chi tiết thời gian
create table time_of_student(
	id_student int,
	id_time int,
	primary key(id_student, id_time),
	FOREIGN KEY (id_student) REFERENCES student(id_student),
	FOREIGN KEY (id_time) REFERENCES times(id_time)
);

