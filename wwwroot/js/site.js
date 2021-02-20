function addExperience() {
    var e = document.getElementById('ExperienceWrapper');
    var i = e.childElementCount;

    // divs
    var fg = document.createElement("div");
    fg.id = "Experience" + i;
    fg.classList.add('form-group', 'mb-2', 'mb-2');

    var rw = document.createElement("div");
    rw.classList.add('row');
    rw.classList.add('bg-light');

        // cl4
    var cl4 = document.createElement("div");
    cl4.classList.add('col-lg-4');

    var cl4SDL = document.createElement("label");
    var cl4SDI = document.createElement("input");
    cl4SDL.classList.add('form-label');
    cl4SDI.classList.add('form-control', 'mb-2');
    cl4SDI.setAttribute("name", `Experiences[${i}].StartDate`);
    cl4SDI.type = "text";
    cl4SDI.id = `Experiences[${i}].StartDate`;
    cl4SDL.innerText = "Start Date";

    var cl4EDL = document.createElement("label");
    var cl4EDI = document.createElement("input");
    cl4EDL.classList.add('form-label');
    cl4EDI.classList.add('form-control', 'mb-2');
    //cl4EDI.setAttribute("name", `EED{${i}}`);
    cl4EDI.setAttribute("name", `Experiences[${i}].EndDate`);
    cl4EDI.id = `Experiences[${i}].EndDate`;
    cl4EDL.innerText = "End Date or Current";

    var cl4Company = document.createElement("label");
    var cl4CompanyI = document.createElement("input");
    cl4Company.classList.add('form-label');
    cl4CompanyI.classList.add('form-control', 'mb-2');
    cl4CompanyI.setAttribute("name", `Experiences[${i}].Company`);
    cl4CompanyI.id = `Experiences[${i}].Company`;
    cl4Company.innerText = "Company Name";

    var cl4Title = document.createElement("label");
    var cl4TitleI = document.createElement("input");
    cl4Title.classList.add('form-label');
    cl4TitleI.classList.add('form-control', 'mb-2');
    cl4TitleI.setAttribute("name", `Experiences[${i}].Position`);
    cl4TitleI.id = `Experiences[${i}].Position`;
    cl4Title.innerText = "Position Title";

    cl4.appendChild(cl4SDL);
    cl4.appendChild(cl4SDI);

    cl4.appendChild(cl4EDL);
    cl4.appendChild(cl4EDI);

    cl4.appendChild(cl4Company);
    cl4.appendChild(cl4CompanyI);

    cl4.appendChild(cl4Title);
    cl4.appendChild(cl4TitleI);
        // end cl4


        // cl8
    var cl8 = document.createElement("div");
    cl8.classList.add('col-lg-8');
    var cl8Label = document.createElement("label");
    cl8Label.innerText = "Description";
    cl8Label.classList.add('form-label');
    var cl8TextArea = document.createElement("textarea");
    cl8TextArea.classList.add('form-control', 'mb-2');
    cl8TextArea.rows = 8;
    cl8TextArea.setAttribute("name", `EDescription[${i}]`);
    cl8TextArea.id = `Experiences[${i}].Description`;
    cl8.appendChild(cl8Label);
    cl8.appendChild(cl8TextArea);
        // end cl8
    // end divs

    var hr = document.createElement('hr');
    hr.classList.add('mt-2', 'mb-2');

    rw.appendChild(cl4);
    rw.appendChild(cl8);
    rw.appendChild(hr);
    fg.appendChild(rw);


   // document.getElementById("MyElement").classList.add('MyClass');

   // document.getElementById("MyElement").classList.remove('MyClass');

   // if (document.getElementById("MyElement").classList.contains('MyClass'))

   //document.getElementById("MyElement").classList.toggle('MyClass');


    var html = '    \
    < div class="form-group" > \
        < div class="row bg-light" > \
        <div class="col-lg-4"> \
            <label class="form-label">Company</label> \
            <input class="form-control" /> \
            <label class="form-label">Position</label> \
            <input class="form-control" /> \
            <label class="form-label">Start Date:</label> \
            <input class="form-control" /> \
            <label class="form-label">End Date:</label> \
            <input class="form-control" /> \
        </div> \
        <div class="col-lg-8"> \
            <label asp-for="Experience" class="form-label">Description</label> \
            <textarea asp-for="Experience" class="form-control" rows="8"></textarea> \
            <span asp-validation-for="Experience" class="text-danger"></span> \
        </div> \
    </div > \
    </div > \
        <hr />';

  
    e.appendChild(fg);
}


