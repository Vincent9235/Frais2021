#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: Clubs
#------------------------------------------------------------

CREATE TABLE Clubs(
        idClub       Int  Auto_increment  NOT NULL ,
        nom_club     Varchar (50) NOT NULL ,
        adresse_club Varchar (100) NOT NULL ,
        cp_club      Varchar (5) NOT NULL ,
        ville_club   Varchar (100) NOT NULL ,
        tel_club     Varchar (10) NOT NULL ,
        email_club   Varchar (60) NOT NULL
	,CONSTRAINT Clubs_PK PRIMARY KEY (idClub)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Ligues
#------------------------------------------------------------

CREATE TABLE Ligues(
        idLigue       Int  Auto_increment  NOT NULL ,
        nom_ligue     Varchar (70) NOT NULL ,
        adresse_ligue Varchar (100) NOT NULL ,
        cp_ligue      Varchar (5) NOT NULL ,
        ville_ligue   Varchar (100) NOT NULL ,
        tel_ligue     Varchar (10) NOT NULL ,
        email_ligue   Varchar (60) NOT NULL
	,CONSTRAINT Ligues_PK PRIMARY KEY (idLigue)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Valideur
#------------------------------------------------------------

CREATE TABLE Valideur(
        idValideur      Int  Auto_increment  NOT NULL ,
        nom_valideur    Varchar (30) NOT NULL ,
        prenom_valideur Varchar (30) NOT NULL
	,CONSTRAINT Valideur_PK PRIMARY KEY (idValideur)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Roles
#------------------------------------------------------------

CREATE TABLE Roles(
        role_id   Int  Auto_increment  NOT NULL ,
        role_nom  Varchar (30) NOT NULL ,
        role_role Varchar (30) NOT NULL
	,CONSTRAINT Roles_PK PRIMARY KEY (role_id)
)ENGINE=InnoDB;

insert into roles(role_role,role_nom) values ('ADM','Administrateur');
insert into roles(role_role,role_nom) values ('MEM','Membre');
insert into roles(role_role,role_nom) values ('RES','Responsable');
#------------------------------------------------------------
# Table: Adherents
#------------------------------------------------------------

CREATE TABLE Adherents(
        id_adherent            Int  Auto_increment  NOT NULL ,
        nom_adherent           Varchar (50) NOT NULL ,
        prenom_adherent        Varchar (50) NOT NULL ,
        dateNaissance_adherent Date NOT NULL ,
        adresse_adherent       Varchar (100) NOT NULL ,
        cp_adherent            Varchar (5) NOT NULL ,
        ville_adherent         Varchar (60) NOT NULL ,
        tel_adherent           Varchar (10) NOT NULL ,
        email_adherent         Varchar (60) NOT NULL ,
        mdp_adherent           Char (255) NOT NULL ,
        role_id                Int NOT NULL
	,CONSTRAINT Adherents_PK PRIMARY KEY (id_adherent)

	,CONSTRAINT Adherents_Roles_FK FOREIGN KEY (role_id) REFERENCES Roles(role_id)
)ENGINE=InnoDB;

insert into adherents (nom_adherent,email_adherent,mdp_adherent) values ("Administrateur","admin",sha2('admin',0));

#------------------------------------------------------------
# Table: Frais
#------------------------------------------------------------

CREATE TABLE Frais(
        id_frais    Int  Auto_increment  NOT NULL ,
        motif_frais Varchar (100) NOT NULL ,
        id_adherent Int NOT NULL ,
        idLigue     Int NOT NULL
	,CONSTRAINT Frais_PK PRIMARY KEY (id_frais)

	,CONSTRAINT Frais_Adherents_FK FOREIGN KEY (id_adherent) REFERENCES Adherents(id_adherent)
	,CONSTRAINT Frais_Ligues0_FK FOREIGN KEY (idLigue) REFERENCES Ligues(idLigue)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Adherer
#------------------------------------------------------------

CREATE TABLE Adherer(
        id_adherent Int NOT NULL ,
        idClub      Int NOT NULL ,
        Licence     Varchar (30) NOT NULL
	,CONSTRAINT Adherer_PK PRIMARY KEY (id_adherent,idClub)

	,CONSTRAINT Adherer_Adherents_FK FOREIGN KEY (id_adherent) REFERENCES Adherents(id_adherent)
	,CONSTRAINT Adherer_Clubs0_FK FOREIGN KEY (idClub) REFERENCES Clubs(idClub)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: faire partie
#------------------------------------------------------------

CREATE TABLE faire_partie(
        idLigue Int NOT NULL ,
        idClub  Int NOT NULL
	,CONSTRAINT faire_partie_PK PRIMARY KEY (idLigue,idClub)

	,CONSTRAINT faire_partie_Ligues_FK FOREIGN KEY (idLigue) REFERENCES Ligues(idLigue)
	,CONSTRAINT faire_partie_Clubs0_FK FOREIGN KEY (idClub) REFERENCES Clubs(idClub)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: valide
#------------------------------------------------------------

CREATE TABLE valide(
        id_frais        Int NOT NULL ,
        idValideur      Int NOT NULL ,
        date_validation Date NOT NULL
	,CONSTRAINT valide_PK PRIMARY KEY (id_frais,idValideur)

	,CONSTRAINT valide_Frais_FK FOREIGN KEY (id_frais) REFERENCES Frais(id_frais)
	,CONSTRAINT valide_Valideur0_FK FOREIGN KEY (idValideur) REFERENCES Valideur(idValideur)
)ENGINE=InnoDB;

