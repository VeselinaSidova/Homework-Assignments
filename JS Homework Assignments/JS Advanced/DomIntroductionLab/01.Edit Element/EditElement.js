function editElement(doc, match, replacer) {
    let content = doc.textContent;
    let matcher = new RegExp(match, 'g');
    let editedElement = content.replace(matcher, replacer);
    doc.textContent = editedElement;
}