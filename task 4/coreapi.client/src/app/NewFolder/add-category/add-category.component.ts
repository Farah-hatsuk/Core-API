import { Component } from '@angular/core';
import { UrlService } from '../../service/url.service';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-add-category',
  standalone: false,
  templateUrl: './add-category.component.html',
  styleUrl: './add-category.component.css'
})
export class AddCategoryComponent {
  constructor(private _url: UrlService, private _route: Router) { }

  addCategory(data: any) {
    var formData = new FormData();
    formData.append("Name", data.Name)
    formData.append("Description", data.Description)

    this._url.postCategory(formData).subscribe(() => {
      alert("Added")
    });
   
  }
}
