CREATE TABLE Contacts
(
	email                varchar(50) NOT NULL,
	passwd            text NOT NULL,
	visibleEmail         text NULL,
	JID                  text NULL,
	ICQ                  text NULL,
	MSN 		     text null
);

alter table Contacts
add primary key(gUserId, email, passwd);

CREATE TABLE Users (gUserId serial not null,  Nick text not null, 
email text not null, passwd text not null,
photo bytea null);

alter table Users
add primary key(gUserId, email, passwd);

alter table Contacts
add constraint Users_Contacts foreign key(gUserId, email, passwd)
references Users(gUserId, email, passwd);
