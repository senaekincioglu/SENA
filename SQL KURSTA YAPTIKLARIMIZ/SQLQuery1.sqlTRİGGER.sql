use Banka
go
create trigger HavaleYap
on Havale
after insert 
as
declare @alici int
declare @gonderici int
declare @tutar float
select @alici=AliciID,@gonderici=GondericiID,@tutar=Tutar from inserted
update MusteriBilgi set Bakiye=Bakiye-@tutar
where MusteriID=@gonderici
go