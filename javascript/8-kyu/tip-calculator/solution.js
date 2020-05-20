function calculateTip(amount, rating) {
  let tipPercent;
  const formatRating = rating.toLowerCase();

  switch (formatRating) {
    case "terrible":
      tipPercent = 0;
      break;
    case "poor":
      tipPercent = 0.05;
      break;
    case "good":
      tipPercent = 0.1;
      break;
    case "great":
      tipPercent = 0.15;
      break;
    case "excellent":
      tipPercent = 0.2;
      break;
  }

  if (tipPercent != null) {
    return Math.ceil(amount * tipPercent);
  } else {
    return "Rating not recognised";
  }
}
