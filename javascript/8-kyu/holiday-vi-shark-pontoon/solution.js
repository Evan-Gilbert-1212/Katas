function shark(pontoonDistance, sharkDistance, youSpeed, sharkSpeed, dolphin) {
  let timeToBoat = pontoonDistance / youSpeed;

  let timeUntilEaten = sharkDistance / (dolphin ? sharkSpeed / 2 : sharkSpeed);

  return timeToBoat < timeUntilEaten ? "Alive!" : "Shark Bait!";
}
