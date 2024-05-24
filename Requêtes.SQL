
DELIMITER //

CREATE PROCEDURE `SP_AjouterClientReservation`(
    IN p_Civilite VARCHAR(50),
    IN p_Nom VARCHAR(50),
    IN p_Prenom VARCHAR(50),
    IN p_AdresseRue VARCHAR(50),
    IN p_AdresseVille VARCHAR(50),
    IN p_AdresseCP VARCHAR(50),
    IN p_Telephone INT,
    IN p_CodeVoiture INT,
    IN p_DateDepart DATE,
    IN p_DateRetour DATE
)
BEGIN
    DECLARE v_ClientID SMALLINT;

    -- Ajouter un nouveau client
    INSERT INTO client (civilite, nom, prenom, adrRue, adrVille, adrCp, telephone)
    VALUES (p_Civilite, p_Nom, p_Prenom, p_AdresseRue, p_AdresseVille, p_AdresseCP, p_Telephone);

    -- Récupérer l'ID du client ajouté
    SET v_ClientID = LAST_INSERT_ID();

    -- Ajouter une nouvelle réservation
    INSERT INTO reservation (idClient, codeCategorie, dateDepart, dateRetour)
    VALUES (v_ClientID, p_CodeVoiture, p_DateDepart, p_DateRetour);
    
    -- Marquer la catégorie de voiture comme réservée
    UPDATE categorie SET estReserve = '1' WHERE CODE = p_CodeVoiture;
END

DELIMITER ;

--

DELIMITER //

CREATE PROCEDURE SP_InsertTourisme (IN categ_voiture VARCHAR(50), categ_tarif DECIMAL(5,2), tourisme_clim INT(2), tourisme_nbPortes INT(2),tourisme_nbPassagers INT(2),tourisme_nbBagages INT(2))
BEGIN
	INSERT INTO categorie (exemple, tarifJournalier) VALUES (categ_voiture, categ_tarif);
	INSERT INTO tourisme
	VALUES (LAST_INSERT_ID(), tourisme_clim, tourisme_nbPortes, tourisme_nbPassagers, tourisme_nbBagages);
END//

DELIMITER ;

--

DELIMITER //

CREATE PROCEDURE SP_InsertUtilitaire (IN categ_voiture VARCHAR(50), categ_tarif DECIMAL(5,2), utilitaire_volume DECIMAL(10,2), utilitaire_chargeUtile DECIMAL(10,2),utilitaire_longueur DECIMAL(10,2),utilitaire_largeur DECIMAL(10,2), utilitaire_hauteur DECIMAL(10,2))
BEGIN
	INSERT INTO categorie (exemple, tarifJournalier) VALUES (categ_voiture, categ_tarif);
	INSERT INTO utilitaire
	VALUES (LAST_INSERT_ID(), utilitaire_volume, utilitaire_chargeUtile, utilitaire_longueur, utilitaire_largeur, utilitaire_hauteur);
END//

DELIMITER ;

--

DELIMITER //

CREATE TRIGGER reservation_after_insert
AFTER INSERT ON reservation
FOR EACH ROW
BEGIN
    DECLARE currentDate DATE;
    DECLARE reservationReturnDate DATE;

    -- Récupérer la date d'aujourd'hui
    SET currentDate = CURDATE();

    -- Récupérer la date de retour de la réservation insérée
    SELECT DATERETOUR INTO reservationReturnDate FROM reservation WHERE numero = NEW.numero;

    -- Vérifier si la date de retour est inférieure ou égale à la date d'aujourd'hui
    IF reservationReturnDate <= currentDate THEN
        -- Mettre à jour estReserve à 0 pour la rendre disponible
        UPDATE categorie SET estReserve = 0 WHERE code = NEW.code;
    END IF;
END//

DELIMITER ;
