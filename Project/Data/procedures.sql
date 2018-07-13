create procedure DohvatiRacuneKupca
	@idKupac int
as
begin
	select * from Kupac as k
	inner join Racun as r
	on k.IDKupac = r.KupacID
	where k.IDKupac=@idKupac
end
go

create proc DohvatiRacune
    @id int
as
    select * from racun
    where @id = KupacID
go

create procedure GetKomercijalist
	@idKomercijalist int
as
begin
	select Ime, Prezime from Komercijalist where Komercijalist.IDKomercijalist = @idKomercijalist
end
go

CREATE PROCEDURE GetDrzava
	@gradID int
AS
BEGIN
	select * from Drzava where 
	IDDrzava in (select DrzavaID from Grad where IDGrad=@gradID)
END
GO

CREATE PROCEDURE GetGradovi
AS
BEGIN
	select * from Grad
END
GO

create procedure GetGrad
	@IDGrad int
as
begin
	select * from Grad where IDGrad = @IDGrad
end
go


create procedure GetKupljeniProizvodi
	@idRacun int
as
begin
	select s.IDStavka, s.Kolicina, p.* from Stavka as s
	inner join Proizvod as p
	on s.ProizvodID=p.IDProizvod
	where s.RacunID=@idRacun
end
go

create procedure GetRacun
	@idRacun int
as
begin
	select * from Racun where Racun.IDRacun=@idRacun
end
go

create procedure GetKreditnaKartica
	@idKK int
as
begin
	select Tip from KreditnaKartica where IDKreditnaKartica=@idKK
end
go

CREATE PROCEDURE GetKupac
	@id int
AS
BEGIN
	select * from Kupac where IDKupac=@id
END
GO


CREATE PROCEDURE GradKupca
	@gradID int
AS
BEGIN
	select * from Grad where IDGrad=@gradID
END
GO

create PROCEDURE DohvatiKupce
AS
BEGIN
	select * from Kupac
END
GO

create PROCEDURE GetDrzave
AS
BEGIN
	select * from Drzava
END
GO


CREATE PROCEDURE UpdateKupac
	@id int,
	@ime nvarchar(50),
	@prezime nvarchar(50),
	@email nvarchar(50),
	@telefon nvarchar(25),
	@gradID int
AS
BEGIN
	update Kupac set Ime=@ime, Prezime=@prezime, Email=@email, Telefon=@telefon, GradID=@gradID where IDKupac=@id 
END
GO


CREATE PROCEDURE DeleteKupac
	@id int
AS
BEGIN
	delete from Kupac where IDKupac=@id 
END
GO

CREATE PROCEDURE InsertKupac
	@ime nvarchar(50),
	@prezime nvarchar(50),
	@email nvarchar(50),
	@telefon nvarchar(25),
	@gradID int
AS
BEGIN
	insert into Kupac values(@ime,@prezime,@email,@telefon,@gradID)
END
GO