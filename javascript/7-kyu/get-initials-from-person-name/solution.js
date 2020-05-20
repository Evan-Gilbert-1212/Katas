function toInitials(name) {
  return name.match(/[A-Z]/g).join(". ").concat(".");
}
