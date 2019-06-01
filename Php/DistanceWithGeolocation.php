
<?php
function getDistance(array $firstLocation, array $secondLocation)
{
    /**
     * 
     * los parametros a pasar deberian tener la siguiente estructura
     * 
     * $firstLocation = ["longitude" => 89.56, "latitude" => 24.78];
     * $secondLocation = ["longitude" => 89.53, "latitude" => 24.89];
    */
    if (is_array($firstLocation) && is_array($secondLocation)) {
        $degtorad = 0.01745329;
        $radtodeg = 57.29577951;
        $dlong = ($firstLocation["longitude"] - $secondLocation["longitude"]);
        $dvalue = (sin($firstLocation["latitude"] * $degtorad) * sin($secondLocation["latitude"] * $degtorad))
            + (cos($firstLocation["latitude"] * $degtorad) * cos($secondLocation["latitude"] * $degtorad)
                * cos($dlong * $degtorad));
        $dd = acos($dvalue) * $radtodeg;
        $km = ($dd * 111.302);
        $km = ($km * 100) / 100;
        return "La distancia entre estos dos puntos geograficos de $km km";
    }
    return "Los parametros ingresados no son validos";
}