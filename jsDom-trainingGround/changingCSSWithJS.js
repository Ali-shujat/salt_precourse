function addStyleBasedOfContent(element, content) {
    const convertedNumber = Number(content);
  
    if(Number.isNaN(convertedNumber)) {
      return;
    }
    if(convertedNumber < 0) {
      element.classList.add('negativeResult');
      return;
    }
    element.classList.add('positiveResult');
  }
  function addResultStyling() {
    const mainResultElements = document.querySelectorAll('.mainResult');
  
    for (let i = 0; i < mainResultElements.length; i++) {
      const content = mainResultElements[i].textContent;
  
      addStyleBasedOfContent(mainResultElements[i], content);
    }
  }