function sovle(input) {
    let students = JSON.parse(input);
    let first = students[0];

    let html = '<table>\n';

    html += `   <tr>${Object.keys(first).map(x => `<th>${escapeHtml(x)}</th>`).join('')}</tr>`;
    students.forEach(student => {
        html += '\n   <tr>';
        html += Object.values(student).map(x => `<td>${escapeHtml(x)}</td>`).join('');
        html += '</tr>';
    })
    html += '\n</table>';

    console.log(html);

    function escapeHtml(value) {
        return value
            .toString()
            .replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
    }
}

sovle(`[{"Name":"Stamat",
"Score":5.5},
{"Name":"Rumen",
"Score":6}]`);