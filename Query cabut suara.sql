update tb_suara set suara_masuk = suara_masuk-1 where nomor_calon = 06
IF EXISTS(SELECT 1 FROM tb_suara WHERE nomor_calon= 06 and suara_masuk < 1) 
delete from tb_suara where nomor_calon = 06