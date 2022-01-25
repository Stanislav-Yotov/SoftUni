function search() {
   const townsSection = Array.from(document.getElementById('towns').querySelectorAll('li'));
   const searchSection = document.getElementById('searchText').value;
   let matches = 0;

   townsSection.forEach(x => {
      x.style.font = 'normal';
      x.style.textDecoration = 'none';
   })

   townsSection.forEach(x => {
      if(x.textContent.includes(searchSection)){
         matches++;
         x.style.fontWeight = 'bolder';
         x.style.textDecoration = 'underline';
      }
   })

   document.getElementById('result').textContent = `${matches} matches found`;
}
