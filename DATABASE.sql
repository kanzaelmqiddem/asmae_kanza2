create database petclinic
use petclinic
create table login(username varchar(20), password varchar(20))
insert into login values('kanza','2002')

n_animal,genre,Age,categorie,alergie,n_prop,n_prop,adresse_prop,tel
create table patient(id_patient int  primary key,n_animal varchar(20),genre varchar(20),Age int ,categorie varchar(20) ,alergie varchar(20),n_prop varchar(20),adresse_prop varchar(50),tel varchar(20))

	

select * from patient
insert into()

create table medicament(id_med int primary key ,nom_med varchar(20),type_med varchar(20) 
check(type_med='ANTIPARASITAIRES'and type_med='ANTIBIOTIQUES'and type_med='ANTI-INFLAMMATOIRES'and type_med='ANTI-METABOLIQUES'and type_med='VACCIN'),categorie_med varchar(20) check(categorie_med='Chat'and categorie_med='Chien'),quantite int,prix float)

create table cash(id_patient int foreign key references patient(id_patient),id_med int foreign key references medicament(id_med),quantite_cash int,prix_cash float)
