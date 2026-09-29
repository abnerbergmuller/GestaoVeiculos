CREATE TABLE marca (
id SERIAL PRIMARY KEY,
nome VARCHAR(20) NOT NULL
);

CREATE TABLE veiculo (
id SERIAL PRIMARY KEY,
placa VARCHAR(7) NOT NULL,
modelo VARCHAR(50) NOT NULL,
-- Nota: A coluna "ano" aceita NULL pois o enunciado não especificou obrigatoriedade, 
-- mas restringe o intervalo caso preenchida.
ano INT,
tipo_veiculo VARCHAR(50) NOT NULL,
marca_id INT NOT NULL
);

CREATE TABLE log_transacao (
id SERIAL PRIMARY KEY,
tipo_operacao VARCHAR(10) NOT NULL,
data_hora TIMESTAMP NOT NULL,
veiculo_id INT
);

CREATE TABLE log_erro (
id SERIAL PRIMARY KEY,
data_hora TIMESTAMP NOT NULL,
mensagem TEXT NOT NULL,
local_erro TEXT NOT NULL,
codigo_erro VARCHAR(10) NULL,
rastro_codigo TEXT NULL
);

--Adição de contraints
ALTER TABLE marca ADD CONSTRAINT ck_marca_id CHECK (id <> 0);
ALTER TABLE marca ADD CONSTRAINT uq_marca_nome UNIQUE (nome);
ALTER TABLE marca ADD CONSTRAINT ck_marca_nome CHECK (TRIM(nome) <> '');

ALTER TABLE veiculo ADD CONSTRAINT fk_veiculo_marca FOREIGN KEY (marca_id) REFERENCES marca(id);
ALTER TABLE veiculo ADD CONSTRAINT ck_veiculo_id CHECK (id <> 0);
ALTER TABLE veiculo ADD CONSTRAINT uq_veiculo_placa UNIQUE (placa);
ALTER TABLE veiculo ADD CONSTRAINT ck_veiculo_placa CHECK (TRIM(placa) <> '');
ALTER TABLE veiculo ADD CONSTRAINT ck_veiculo_modelo CHECK (TRIM(modelo) <> '');
ALTER TABLE veiculo ADD CONSTRAINT ck_veiculo_ano 
CHECK (ano >= 1950 AND ano <= EXTRACT(YEAR FROM CURRENT_DATE));
ALTER TABLE veiculo ADD CONSTRAINT ck_veiculo_marca_id CHECK (marca_id <> 0);


--Trigger Function da tabela veiculo 
CREATE OR REPLACE FUNCTION tg_fn_veiculo_auditoria()
RETURNS TRIGGER AS $$
BEGIN

	IF (TG_OP = 'INSERT' OR TG_OP = 'UPDATE') THEN
		INSERT INTO log_transacao(tipo_operacao, data_hora, veiculo_id)	
		VALUES(TG_OP, CURRENT_TIMESTAMP, NEW.id);
		RETURN NEW;

	ELSIF (TG_OP = 'DELETE') THEN
		INSERT INTO log_transacao(tipo_operacao, data_hora, veiculo_id)	
		VALUES(TG_OP, CURRENT_TIMESTAMP, OLD.id);
		RETURN OLD;
	END IF;
END;
$$ LANGUAGE plpgsql;

--Trigger da tabela veiculo
CREATE TRIGGER tg_veiculo_after_iud
	AFTER INSERT OR UPDATE OR DELETE ON veiculo
	FOR EACH ROW
	EXECUTE FUNCTION tg_fn_veiculo_auditoria();

--Insert inicial
INSERT INTO marca(nome) VALUES 
('Toyota'),
('Volkswagen'),
('Ford');
