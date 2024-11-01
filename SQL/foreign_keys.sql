-- Добаление вторичных ключей для таблицы Request

ALTER TABLE "Request" ADD CONSTRAINT fk_request_software FOREIGN KEY (id_software) REFERENCES 
"Software" (id);

ALTER TABLE "Request" ADD CONSTRAINT fk_request_developer FOREIGN KEY (id_developer) REFERENCES 
"Developer" (id);

ALTER TABLE "Request" ADD CONSTRAINT fk_request_device FOREIGN KEY (id_device) REFERENCES 
"Device" (id);


-- Добаление вторичных ключей для таблицы Software

ALTER TABLE "Software" ADD CONSTRAINT fk_software_device FOREIGN KEY (id_device) REFERENCES 
"Device" (id);

ALTER TABLE "Software" ADD CONSTRAINT fk_software_developer FOREIGN KEY (id_developer) REFERENCES 
"Developer" (id);


-- -- Добаление вторичного ключа для таблицы User

ALTER TABLE "User" ADD CONSTRAINT fk_user_device FOREIGN KEY (id_device) REFERENCES 
"Device" (id);





