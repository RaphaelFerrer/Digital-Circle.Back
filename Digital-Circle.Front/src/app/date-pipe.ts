import { Pipe, PipeTransform } from '@angular/core';
import { DatePipe } from '@angular/common';

@Pipe({
  name: 'customDateFormat'
})
export class CustomDateFormatPipe implements PipeTransform {
  transform(value: any, format: string = 'dd/MM/yyyy HH:mm:ss'): any {
    const datePipe = new DatePipe('en-US');
    return datePipe.transform(value, format);
  }
}
