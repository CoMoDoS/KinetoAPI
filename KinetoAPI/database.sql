create table cabinet."user"
(
	id serial not null
		constraint user_pk
			primary key,
	name varchar,
	username varchar,
	password varchar,
	role varchar,
	status varchar
);

alter table cabinet."user" owner to postgres;

create unique index user_id_uindex
	on cabinet."user" (id);



create table cabinet.patient
(
	id serial not null
		constraint patient_pk
			primary key,
	name varchar,
	phonenumber varchar,
	appointmentsdone integer,
	appointmentstotal integer,
	lastpay date,
	addedby integer
		constraint patient_user_id_fk
			references cabinet."user"
				on update cascade on delete cascade,
	status varchar
);

alter table cabinet.patient owner to postgres;

create unique index patient_id_uindex
	on cabinet.patient (id);



create table cabinet.treatment
(
	id serial not null
		constraint treatment_pk
			primary key,
	name varchar,
	description varchar,
	price double precision,
	status varchar
);

alter table cabinet.treatment owner to postgres;

create unique index treatment_id_uindex
	on cabinet.treatment (id);



create table cabinet.appointment
(
	id serial not null
		constraint appointment_pk
			primary key,
	idPatient integer not null
		constraint appointment_patient_id_fk
			references cabinet.patient
				on update cascade on delete cascade,
	idTreatment integer not null
		constraint appointment_treatment_id_fk
			references cabinet.treatment
				on update cascade on delete cascade,
	date timestamp,
	done boolean,
	addedBy integer,
	status varchar
);

alter table cabinet.appointment owner to postgres;

create unique index appointment_id_uindex
	on cabinet.appointment (id);



INSERT  into  cabinet.user (name,username, password, role, status) values ('Edith', 'edith', 'PasEdith1', 'ADMIN', '1');
INSERT  into  cabinet.user (name,username, password, role, status) values ('Juli', 'juli', 'PasJuli1', '1', '1');
INSERT  into  cabinet.user (name,username, password, role, status) values ('Stefan', 'stefan', 'PasStefan1', '1', '1');
INSERT  into  cabinet.user (name,username, password, role, status) values ('Adina', 'adina', 'PasAdine1', '1', '1');
INSERT  into  cabinet.user (name,username, password, role, status) values ('Rozii', 'rozii', 'PasRozii1', '2', '1');
INSERT  into  cabinet.user (name,username, password, role, status) values ('Alice', 'alice', 'PasAlice1', '2', '1');

select * from cabinet.user;
select * from cabinet.appointment;


insert into cabinet.treatment (name, description, price, status) values ('kineto 10', '10 sedinte kinetoterapie', 500, '1');
insert into cabinet.treatment (name, description, price, status) values ('masaj 10', '10 sedinte masaj', 300, '1');
insert into cabinet.treatment (name, description, price, status) values ('fizioterapie', '10 sedinte fizioterapie', 600, '1');
insert into cabinet.treatment (name, description, price, status) values ('crio 10', '10 sedinte crioterapie', 200, '1');

select * from cabinet.treatment;

insert into cabinet.patient (name, phone_number, appointments_done, appointments_total, last_pay, added_by, status) 
values ('Ilie', '0769288360', 0,0,now(), 2, '1');
insert into cabinet.patient (name, phone_number, appointments_done, appointments_total, last_pay, added_by, status)
values ('Alex 7', '0769288361', 0,0,now(), 2, '1');
insert into cabinet.patient (name, phone_number, appointments_done, appointments_total, last_pay, added_by, status)
values ('Maria', '0769288362', 0,0,now(), 3, '1');

select * from cabinet.patient;

insert into cabinet.appointment ( id_patient, id_treatment, date, done, added_by, status)
values (2,1,now(), false, 3, '1');
insert into cabinet.appointment ( id_patient, id_treatment, date, done, added_by, status)
values (3,4,now(), false, 3, '1');
insert into cabinet.appointment ( id_patient, id_treatment, date, done, added_by, status)
values (4,2,now(), false, 3, '1');

select * from cabinet.appointment;



#DataSourceSettings#
#LocalDataSource: postgres@localhost
#BEGIN#
<data-source source="LOCAL" name="postgres@localhost" uuid="9b716350-7724-4bfc-ada6-1b93f8802bb0"><database-info product="PostgreSQL" version="10.10 (Ubuntu 10.10-0ubuntu0.18.04.1)" jdbc-version="4.2" driver-name="PostgreSQL JDBC Driver" driver-version="42.2.5" dbms="POSTGRES" exact-version="10.10" exact-driver-version="42.2"><identifier-quote-string>&quot;</identifier-quote-string></database-info><case-sensitivity plain-identifiers="lower" quoted-identifiers="exact"/><driver-ref>postgresql</driver-ref><synchronize>true</synchronize><jdbc-driver>org.postgresql.Driver</jdbc-driver><jdbc-url>jdbc:postgresql://localhost:5432/postgres</jdbc-url><secret-storage>master_key</secret-storage><user-name>postgres</user-name><schema-mapping><introspection-scope><node negative="1"><node kind="database" qname="@"><node kind="schema" qname="@"/></node><node kind="database" qname="cabinet"><node kind="schema" qname="cabinet"/></node></node></introspection-scope></schema-mapping></data-source>
#END#

