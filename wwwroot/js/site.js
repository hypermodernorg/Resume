function addExperience() {
    var e = document.getElementById('ExperienceWrapper');
    var i = e.childElementCount;


    var fg = document.createElement("div");
    fg.id = "Experience" + i;
    fg.classList.add('form-group', 'mb-2', 'mb-2');

    var rw = document.createElement("div");
    rw.classList.add('row');
    rw.classList.add('bg-light');


    var rw2 = document.createElement("div");
    rw2.classList.add('row', 'mb-2');
    var col2 = document.createElement('div');
    col2.classList.add('col', 'text-end');

    // Remove element column
    var cl1 = document.createElement("div");
    cl1.classList.add('col-lg-1');
    var aRemove = document.createElement("a");
    aRemove.setAttribute('onclick', `deleteElement('${fg.id}')`);
    aRemove.classList.add('text-danger');
    aRemove.innerText = "Delete";
    cl1.appendChild(aRemove);
    col2.appendChild(aRemove);
    rw2.appendChild(col2);

    // Start and End Date, Company Name, and Position Title Columns
    var cl4 = document.createElement("div");
    cl4.classList.add('col-lg-4');
    var cl4SDL = document.createElement("label");
    var cl4SDI = document.createElement("input");
    cl4SDL.classList.add('form-label');
    cl4SDI.classList.add('form-control', 'mb-2');
    cl4SDI.setAttribute("name", `Experiences[${i}].StartDate`);
    cl4SDI.type = "date";
    cl4SDI.id = `Experiences[${i}].StartDate`;
    cl4SDL.innerText = "Start Date";

    var sdff = document.createElement("div");
    sdff.classList.add('form-floating');
    sdff.appendChild(cl4SDI);
    sdff.appendChild(cl4SDL);



    var cl4EDL = document.createElement("label");
    var cl4EDI = document.createElement("input");
    cl4EDL.classList.add('form-label');
    cl4EDI.classList.add('form-control', 'mb-2');
    cl4EDI.setAttribute("name", `Experiences[${i}].EndDate`);
    cl4EDI.type = "date";
    cl4EDI.id = `Experiences[${i}].EndDate`;
    cl4EDL.innerText = "End Date or Current";

    var edff = document.createElement("div");
    edff.classList.add('form-floating');
    edff.appendChild(cl4EDI);
    edff.appendChild(cl4EDL);


    var cl4Company = document.createElement("label");
    var cl4CompanyI = document.createElement("input");
    cl4Company.classList.add('form-label');
    cl4CompanyI.classList.add('form-control', 'mb-2');
    cl4CompanyI.setAttribute("name", `Experiences[${i}].Company`);
    cl4CompanyI.id = `Experiences[${i}].Company`;
    cl4Company.innerText = "Company Name";

    var cnff = document.createElement("div");
    cnff.classList.add('form-floating');
    cnff.appendChild(cl4CompanyI);
    cnff.appendChild(cl4Company);


    var cl4Title = document.createElement("label");
    var cl4TitleI = document.createElement("input");
    cl4Title.classList.add('form-label');
    cl4TitleI.classList.add('form-control', 'mb-2');
    cl4TitleI.setAttribute("name", `Experiences[${i}].Position`);
    cl4TitleI.id = `Experiences[${i}].Position`;
    cl4Title.innerText = "Position Title";

    var tff = document.createElement("div");
    tff.classList.add('form-floating');
    tff.appendChild(cl4TitleI);
    tff.appendChild(cl4Title);


    var cl4Location = document.createElement("label");
    var cl4LocationI = document.createElement("input");
    cl4Location.classList.add('form-label');
    cl4LocationI.classList.add('form-control', 'mb-2');
    cl4LocationI.setAttribute("name", `Experiences[${i}].Location`);
    cl4LocationI.id = `Experiences[${i}].Location`;
    cl4Location.innerText = "Location";

    var lff = document.createElement("div");
    lff.classList.add('form-floating');
    lff.appendChild(cl4LocationI);
    lff.appendChild(cl4Location);


    cl4.appendChild(sdff);
    cl4.appendChild(edff);
    cl4.appendChild(cnff);
    cl4.appendChild(tff);
    cl4.appendChild(lff);
    //cl4.appendChild(cl4SDL);
    //cl4.appendChild(cl4SDI);

    //cl4.appendChild(cl4EDL);
    //cl4.appendChild(cl4EDI);

    //cl4.appendChild(cl4Company);
    //cl4.appendChild(cl4CompanyI);

    //cl4.appendChild(cl4Title);
    //cl4.appendChild(cl4TitleI);

    // Description column
    var cl8 = document.createElement("div");
    cl8.classList.add('col-lg-8');
    var cl8Label = document.createElement("label");
    cl8Label.innerText = "Description";
    cl8Label.classList.add('form-label');
    var cl8TextArea = document.createElement("textarea");
    cl8TextArea.classList.add('form-control', 'mb-2', 'rDescription');

    cl8TextArea.setAttribute("name", `Experiences[${i}].Description`);
    cl8TextArea.id = `Experiences[${i}].Description`;
    //cl8.appendChild(cl8Label);
    //cl8.appendChild(cl8TextArea);

    var deff = document.createElement("div");
    deff.classList.add('form-floating');
    deff.appendChild(cl8TextArea);
    deff.appendChild(cl8Label);
    cl8.appendChild(deff);
    // hr divider at the bottom.
    var hr = document.createElement('hr');

    // Lets append all of it to the main divs.
    //rw.appendChild(cl1);
    rw.appendChild(cl4);
    rw.appendChild(cl8);
    fg.appendChild(rw2);
    fg.appendChild(rw);
    fg.appendChild(hr);
    e.appendChild(fg);
}

function addEducation() {
    var e = document.getElementById('EducationWrapper');
    var i = e.childElementCount;

    var fg = document.createElement("div");
    fg.id = "Education" + i;
    fg.classList.add('form-group', 'mb-2', 'mb-2');

    var rw = document.createElement("div");
    rw.classList.add('row');
    rw.classList.add('bg-light');

    var rw2 = document.createElement("div");
    rw2.classList.add('row', 'mb-2');
    var col2 = document.createElement('div');
    col2.classList.add('col', 'text-end');

    // Remove element column
    var cl1 = document.createElement("div");
    cl1.classList.add('col-lg-1');
    var aRemove = document.createElement("a");
    aRemove.setAttribute('onclick', `deleteElement('${fg.id}')`);
    aRemove.classList.add('text-danger');
    aRemove.innerText = "Delete";
    cl1.appendChild(aRemove);
    col2.appendChild(aRemove);
    rw2.appendChild(col2);

   // Start and End Date, School Name, and Degree column
    var cl4 = document.createElement("div");
    cl4.classList.add('col-lg-4');


    var cl4SDL = document.createElement("label");
    var cl4SDI = document.createElement("input");
    cl4SDL.classList.add('form-label');
    cl4SDI.classList.add('form-control', 'mb-2');
    cl4SDI.setAttribute("name", `Educations[${i}].StartDate`);
    cl4SDI.type = "date";
    cl4SDI.id = `Educations[${i}].StartDate`;
    cl4SDL.innerText = "Start Date";

    var sdff = document.createElement("div");
    sdff.classList.add('form-floating');
    sdff.appendChild(cl4SDI);
    sdff.appendChild(cl4SDL);

    var cl4EDL = document.createElement("label");
    var cl4EDI = document.createElement("input");
    cl4EDL.classList.add('form-label');
    cl4EDI.classList.add('form-control', 'mb-2');
    cl4EDI.setAttribute("name", `Educations[${i}].EndDate`);
    cl4EDI.type = "date";
    cl4EDI.id = `Educations[${i}].EndDate`;
    cl4EDL.innerText = "End Date or Current";

    var edff = document.createElement("div");
    edff.classList.add('form-floating');
    edff.appendChild(cl4EDI);
    edff.appendChild(cl4EDL);

    var cl4Company = document.createElement("label");
    var cl4CompanyI = document.createElement("input");
    cl4Company.classList.add('form-label');
    cl4CompanyI.classList.add('form-control', 'mb-2');
    cl4CompanyI.setAttribute("name", `Educations[${i}].School`);
    cl4CompanyI.id = `Educations[${i}].School`;
    cl4Company.innerText = "School Name";

    var snff = document.createElement("div");
    snff.classList.add('form-floating');
    snff.appendChild(cl4CompanyI);
    snff.appendChild(cl4Company);

    var cl4Title = document.createElement("label");
    var cl4TitleI = document.createElement("input");
    cl4Title.classList.add('form-label');
    cl4TitleI.classList.add('form-control', 'mb-2');
    cl4TitleI.setAttribute("name", `Educations[${i}].Degree`);
    cl4TitleI.id = `Educations[${i}].Degree`;
    cl4Title.innerText = "Degree";

    var dff = document.createElement("div");
    dff.classList.add('form-floating');
    dff.appendChild(cl4TitleI);
    dff.appendChild(cl4Title);


    var cl4Location = document.createElement("label");
    var cl4LocationI = document.createElement("input");
    cl4Location.classList.add('form-label');
    cl4LocationI.classList.add('form-control', 'mb-2');
    cl4LocationI.setAttribute("name", `Educations[${i}].Location`);
    cl4LocationI.id = `Educations[${i}].Location`;
    cl4Location.innerText = "Location";

    var lff = document.createElement("div");
    lff.classList.add('form-floating');
    lff.appendChild(cl4LocationI);
    lff.appendChild(cl4Location);

    var cl4GPA = document.createElement("label");
    var cl4GPAI = document.createElement("input");
    cl4GPA.classList.add('form-label');
    cl4GPAI.classList.add('form-control', 'mb-2');
    cl4GPAI.setAttribute("name", `Educations[${i}].GPA`);
    cl4GPAI.id = `Educations[${i}].GPA`;
    cl4GPA.innerText = "GPA";

    var gpaff = document.createElement("div");
    gpaff.classList.add('form-floating');
    gpaff.appendChild(cl4GPAI);
    gpaff.appendChild(cl4GPA);


    cl4.appendChild(sdff);
    cl4.appendChild(edff);
    cl4.appendChild(snff);
    cl4.appendChild(dff);
    cl4.appendChild(lff);
    cl4.appendChild(gpaff);


    // Description column
    var cl8 = document.createElement("div");
    cl8.classList.add('col-lg-8');
    var cl8Label = document.createElement("label");
    cl8Label.innerText = "Description";
    cl8Label.classList.add('form-label');
    var cl8TextArea = document.createElement("textarea");
    cl8TextArea.classList.add('form-control', 'mb-2', 'rDescription');
    cl8TextArea.rows = 10;
    cl8TextArea.setAttribute("name", `Educations[${i}].Description`);
    cl8TextArea.id = `Educations[${i}].Description`;


    var deff = document.createElement("div");
    deff.classList.add('form-floating');
    deff.appendChild(cl8TextArea);
    deff.appendChild(cl8Label);

    cl8.appendChild(deff);
    //cl8.appendChild(cl8Label);
    //cl8.appendChild(cl8TextArea);
    // hr divider at the bottom.
    var hr = document.createElement('hr');

    // Lets append all the the main divs.
    //rw.appendChild(cl1);
    rw.appendChild(cl4);
    rw.appendChild(cl8);
    fg.appendChild(rw2);
    fg.appendChild(rw);
    fg.appendChild(hr);
    e.appendChild(fg);
}

function addSkill() {
    var e = document.getElementById('SkillWrapper');
    var i = e.childElementCount;

    var iRand = Math.floor(Math.random() * 10000) + 999;  // returns a random integer 

    // divs
    var fg = document.createElement("div");
    fg.id = "Skill" + iRand;
    fg.classList.add('form-group', 'mb-2', 'mb-2');

    var rw = document.createElement("div");
    rw.classList.add('row');
    rw.classList.add('bg-light');


    var cl1 = document.createElement("div");
    cl1.classList.add('col-lg-1');
    var aRemove = document.createElement("a");
    var iRemove = document.createElement("i");
    iRemove.classList.add('bi', 'bi-x-square');
    aRemove.appendChild(iRemove);
    aRemove.setAttribute('onclick', `deleteElement('${fg.id}')`);
    aRemove.classList.add('text-danger');

    cl1.appendChild(aRemove);

    var cl2 = document.createElement("div");
    cl2.classList.add('col-lg-3');
    var cl3 = document.createElement("div");
    cl3.classList.add('col-lg-8');


    var cl2Name = document.createElement("label");
    var cl2NameI = document.createElement("input");
    cl2Name.classList.add('form-label');
    cl2NameI.classList.add('form-control', 'mb-2');
    cl2NameI.setAttribute("name", `Skills[${i}].Name`);
    cl2NameI.id = `Skills[${i}].Name`;
    cl2Name.innerText = "Skill Name";

    cl2.appendChild(cl2Name);
    cl2.appendChild(cl2NameI);

    // end cl2
    // cl3
    var sliderContainer = document.createElement("div");
    sliderContainer.classList.add("slidercontainer");
    var SkillRating = document.createElement("label");
    var SkillRatingI = document.createElement("input");
    SkillRatingI.type = "range";
    SkillRatingI.min = 0;
    SkillRatingI.max = 100;
    SkillRatingI.value = 50;
    SkillRatingI.classList.add('mb-2', 'slider');
    SkillRatingI.setAttribute("name", `Skills[${i}].SkillRating`);
    SkillRatingI.id = `Skills[${i}].SkillRating`;
    SkillRating.classList.add('form-label');
    SkillRating.innerText = "Skill Rating - From Left to Right - 0 to 100 Respectively";
    sliderContainer.appendChild(SkillRatingI);
    cl3.appendChild(SkillRating);
    cl3.appendChild(sliderContainer);
    // end cl3
    // end divs

    var hr = document.createElement('hr');

    rw.appendChild(cl1);
    rw.appendChild(cl2);
    rw.appendChild(cl3);
    fg.appendChild(rw);
    fg.appendChild(hr);
    e.appendChild(fg);
}

function deleteElement(element) {
    var elementToRemove = document.getElementById(element);

    elementToRemove.remove();

}

function resumeSlug() {
    var resumeName = document.getElementById('rname').value;
    var rnlower = resumeName.toLowerCase().trim().replaceAll(' ', '-');


    document.getElementById('rslug').value = rnlower;
 
  

}