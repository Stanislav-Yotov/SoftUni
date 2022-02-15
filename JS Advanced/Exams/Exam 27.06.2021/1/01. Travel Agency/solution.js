window.addEventListener('load', solution);

function solution() {
  let fullName = document.getElementById('fname');
  let email = document.getElementById('email');
  let phoneNumber = document.getElementById('phone');
  let address = document.getElementById('address');
  let postCode = document.getElementById('code');
  let submitBtn = document.getElementById('submitBTN');
  let blockElement = document.getElementById('block');

  submitBtn.addEventListener('click', onSubmit);

  let editBtn = document.getElementById('editBTN');
  let continueBtn = document.getElementById('continueBTN');
  let infoPreview = document.getElementById('infoPreview');
  let fullNameBackUp;
  let emailBackUp;
  let phoneBackUp;
  let addressBackup;
  let postCodeBackUp;

  function onSubmit() {

    if (fullName.value == '' || email.value == '') {
      return;
    }

    fullNameBackUp = fullName.value;
    emailBackUp = email.value;
    phoneBackUp = phoneNumber.value;
    addressBackup = address.value;
    postCodeBackUp = postCode.value;

    let fullNameLi = document.createElement('li');
    fullNameLi.textContent = `Full Name: ${fullNameBackUp}`;

    let emailLi = document.createElement('li');
    emailLi.textContent = `Email: ${emailBackUp}`;

    let phoneLi = document.createElement('li');
    phoneLi.textContent = `Phone Number: ${phoneBackUp}`;

    let addressLi = document.createElement('li');
    addressLi.textContent = `Address: ${addressBackup}`;

    let postCodeLi = document.createElement('li');
    postCodeLi.textContent = `Postal Code: ${postCodeBackUp}`;

    infoPreview.appendChild(fullNameLi);
    infoPreview.appendChild(emailLi);
    infoPreview.appendChild(phoneLi);
    infoPreview.appendChild(addressLi);
    infoPreview.appendChild(postCodeLi);

    fullName.value = '';
    email.value = '';
    phoneNumber.value = '';
    address.value = '';
    postCode.value = '';

    submitBtn.disabled = true;
    editBtn.disabled = false;
    continueBtn.disabled = false;
  }

  editBtn.addEventListener('click', onEdit);
  function onEdit(){
    while (infoPreview.firstChild) {
      infoPreview.removeChild(infoPreview.firstChild);
    }
    submitBtn.disabled = false;
    editBtn.disabled = true;
    continueBtn.disabled = true;

    fullName.value = fullNameBackUp;
    email.value = emailBackUp;
    phoneNumber.value = phoneBackUp;
    address.value = addressBackup;
    postCode.value = postCodeBackUp;

  }

  continueBtn.addEventListener('click', onClick);
  function onClick() {
    while (blockElement.firstChild) {
      blockElement.removeChild(blockElement.firstChild);
    }
    let htag = document.createElement('h3');
    htag.textContent = 'Thank you for your reservation!';
    blockElement.appendChild(htag);
  }

}

